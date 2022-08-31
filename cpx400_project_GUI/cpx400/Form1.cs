using cpx400.DEVICES;
using cpx400.Properties;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using Timer = System.Windows.Forms.Timer;

namespace cpx400
{

    public partial class Form1 : Form
    {
        CPX400 cpx400 = new cpx400.DEVICES.CPX400();
        Timer timer = new Timer();
        TimeSpan ts = new TimeSpan(0, 0, 0, 0, 500);

        RS232 rs232 = new RS232();

        

        public Form1() 
        {
            InitializeComponent();
         
        }

        #region CPX400_METHODS


        private void getMeasurement(object sender, EventArgs e)
        {
            double value = 0;
            label3.Text = value.ToString();
            Int32 mesurementType = rbtn_amper.Checked ? 0 : 1; //0 for amper 1 for voltage
            if (rbtn_chname1.Checked)
            {
                cpx400.Measure("1", mesurementType, ref value);
                label3.Text = "Measurement :" + value;
            }
            else
            {

                cpx400.Measure("2", mesurementType, ref value);

                label3.Text = "Measurement :" + value;
            };

        }
        private String getCurrentTime()
        {
            return Environment.NewLine + DateTime.Now.ToString("HH:mm:ss");
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            string statusCode = cpx400.Initialize();
            btn_Connect.Text = "Connected";
            lbl_status.Text = statusCode;                                      
            Color activeColor = Color.Red;
            if (statusCode.Equals("Success"))                                
            {
                timer.Interval = ts.Milliseconds;
                timer.Tick += getMeasurement;
                timer.Start();


                richTextBox1.AppendText(getCurrentTime() + " Successfully connected to Device");
                btn_close.Enabled = true;
                btn_close.BackColor = Color.FromArgb(230, 72, 72);

                btn_reset.Enabled = true;
                btn_reset.BackColor = Color.FromArgb(41, 52, 98);

                groupBox1.Enabled = true;
                groupBox1.ForeColor = Color.Black;

                gb_chanelNames.Enabled = true;


                foreach (Control i in groupBox1.Controls)
                {
                    i.ForeColor = Color.Black;

                }
            }
            else
            {
                btn_Connect.Text = "Connection Error";
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            cpx400.ResetOutputProtection("1");
            cpx400.ResetOutputProtection("2");

            cpx400.Close();

            richTextBox1.AppendText(getCurrentTime() + " CLOSE ");

            groupBox1.Enabled = false;
            btn_Connect.Text = "RECONNECT";

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            cpx400.ResetOutputProtection("1");
            cpx400.ResetOutputProtection("2");

            cpx400.Reset();

            richTextBox1.Clear();
            richTextBox1.AppendText(getCurrentTime() + " RESET ");
        }

        private bool enable = false;
        private void btn_COE_Click(object sender, EventArgs e)
        {
            if (enable)
            {
                btn_COE.BackColor = Color.FromArgb(230, 72, 72);
                btn_COE.Text = " Output Disabled";
                richTextBox1.AppendText(getCurrentTime() + " Configure Output Disabled (chanel: 1)");

                enable = false;
            }
            else
            {
                btn_COE.BackColor = Color.FromArgb(91, 179, 24);
                btn_COE.Text = " Output Enabled";
                richTextBox1.AppendText(getCurrentTime() + " Configure Output Enabled (chanel: 2)");

                enable = true;
            }

            if (rbtn_chname1.Checked && enable)
            {

                cpx400.ConfigureOutputEnabled("1", true); 

            }
            else if (rbtn_chname1.Checked && !enable)
            {
                cpx400.ConfigureOutputEnabled("1", false);

            }
            else if (rbtn_chname2.Checked && enable)
            {
                cpx400.ConfigureOutputEnabled("2", true);

            }
            else if (rbtn_chname2.Checked && !enable)
            {
                cpx400.ConfigureOutputEnabled("2", false);

            }
            else
            {
                MessageBox.Show("invalid operation");
            }
        }

        private void btn_CCL_Click(object sender, EventArgs e)
        {
            double limit = (double)nud_CCL_limit.Value;
            long behavior = (long)nud_CCL_behavior.Value;
            if (rbtn_chname1.Checked == true)
            {
                cpx400.ConfigureCurrentLimit("1", behavior, limit);
                richTextBox1.AppendText(getCurrentTime() + " Configure Current Limit (chanel: 1)");

            }
            else
            {
                cpx400.ConfigureCurrentLimit("2", behavior, limit);
                richTextBox1.AppendText(getCurrentTime() + " Configure Current Limit (chanel: 2)");
            }
        }

        private void btn_COVP_Click(object sender, EventArgs e)
        {
            double limit = (double)nud_COVP_limit.Value;

            if (rbtn_chname1.Checked && rbtn_COVP_true.Checked == true)
            {
                cpx400.ConfigureOVP("1", true, limit);
                richTextBox1.AppendText(getCurrentTime() + " Configure OVP (chanel: 1)");

            }
            else if (rbtn_chname1.Checked && rbtn_COVP_true.Checked == false)
            {
                cpx400.ConfigureOVP("1", false, limit);
                richTextBox1.AppendText(getCurrentTime() + " Configure OVP (chanel: 1)");

            }
            else if (rbtn_chname2.Checked && rbtn_COVP_true.Checked == true)
            {
                cpx400.ConfigureOVP("2", true, limit);
                richTextBox1.AppendText(getCurrentTime() + " Configure OVP (chanel: 2)");

            }
            else if (rbtn_chname2.Checked && rbtn_COVP_true.Checked == false)
            {
                cpx400.ConfigureOVP("2", false, limit);
                richTextBox1.AppendText(getCurrentTime() + " Configure OVP (chanel: 2)");

            }
            else
            {
                MessageBox.Show("invalid operation");
            }
        }

        private void btn_CVL_Click(object sender, EventArgs e)
        {
            double level = (double)nud_CVL_level.Value;
            if(rbtn_chname1.Checked)
            {
              cpx400.ConfigureVoltageLevel("1", level);
                richTextBox1.AppendText(getCurrentTime() + " Configure Voltage Level (chanel: 1)");

            }
            else
            {
               cpx400.ConfigureVoltageLevel("2", level);
                richTextBox1.AppendText(getCurrentTime() + " Configure Voltage Level (chanel: 2)");

            }
        }

        private void btn_COCP_click(object sender, EventArgs e)
        {
            double limit = (double)nud_COCP_limit.Value;
            if (rbtn_chname1.Checked)
            {
               cpx400.CPX400_ConfigureOCP("1", limit);
                richTextBox1.AppendText(getCurrentTime() + " Configure OCP (chanel: 1)");

            }
            else
            {
               cpx400.CPX400_ConfigureOCP("2", limit);
                richTextBox1.AppendText(getCurrentTime() + " Configure OCP (chanel: 2)");

            }
        }

        private void rbtn_chname1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_chname1.Checked)
            {
                lbl_chanelName.Text = "SELECTED CHANEL = 1";
            }
            else
            {
                lbl_chanelName.Text = "SELECTED CHANEL = 2";

            }
        }


        #endregion


        #region rs232 Port A

        private void btn_OpenEx_Click(object sender, EventArgs e)
        {
            string statusCode = rs232.OpenEx_A();
            if (statusCode.Equals("Success")){
                groupBox3.Enabled = true;

                lbl_rs232_status_A.Text= "Status : Success";
                btn_rs232_close_A.Enabled = true;

                btn_rs232_close_A.BackColor =Color.FromArgb(230, 72, 72);
            }
            else
            {
                groupBox3.Enabled = false;
                btn_Open_A.Text = "Connection ERROR Try Again";
                lbl_rs232_status_A.Text = "Status : Failed";

            }
        }

        private void btn_SetDataChar_Click(object sender, EventArgs e)
        {
            byte dataBits = (byte)(int.Parse(cBox_DataBits_A.SelectedItem.ToString()));
    
            byte stopBit;
             int tempStop = (byte)(int.Parse(cBox_StopBits_A.SelectedItem.ToString()));
            if (tempStop == 1)
            {
                stopBit = (byte)0;
            }
            else
            {
                stopBit = (byte)2;
            }
             rs232.SetDataCharacteristics_A(dataBits, stopBit,SelectedParity());
        }

        private void btn_SetTimeout_Click(object sender, EventArgs e)
        {
            uint readTimeOut = (uint)(int)nud_SetTimeout_rto_A.Value;
            uint writeTimeout = (uint)(int)nud_SetTimeout_wto_A.Value; ;

             rs232.SetTimeouts_A(readTimeOut, writeTimeout);
        }

        private void btn_write_Click(object sender, EventArgs e)
        {
            string tmp = txtb_Write_DataBuffer_A.Text;
            byte[] bytes = Encoding.ASCII.GetBytes(tmp);

            int numBytesToWrite = (int)bytes.Length;

            uint value = 1;

            rs232.Write_A(bytes, numBytesToWrite, ref value);
        }

        public enum Parity
        {
            FT_PARITY_NONE = 0,
            FT_PARITY_ODD = 1,
            FT_PARITY_EVEN = 2,
            FT_PARITY_MARK = 3,
            FT_PARITY_SPACE = 4
        }

        public byte SelectedParity()
        {

            Parity parity;
            parity = Parity.FT_PARITY_NONE;

            switch (cBox_Parity_A.SelectedItem.ToString())
            {
                case "Even":
                    parity = Parity.FT_PARITY_EVEN;
                    break;
                case "Odd":
                    parity = Parity.FT_PARITY_ODD;
                    break;
                case "None":
                    parity = Parity.FT_PARITY_NONE;
                    break;
                case "Mark":
                    parity = Parity.FT_PARITY_MARK;
                    break;
                case "Space":
                    parity = Parity.FT_PARITY_SPACE;
                    break;
            }
            return (byte)parity;
        }

        private void btn_rs232_close_Click(object sender, EventArgs e)
        {
            rs232.Close_A();
            groupBox3.Enabled = false;
            cb_A_readLive.Checked = false;
        }

        private void btn_SetBaudRate_Click(object sender, EventArgs e)
        {
            uint tmp = uint.Parse(cBox_BitPerSecond_A.SelectedItem.ToString());
            uint baudRate = tmp;

            rs232.SetBaudRate_A(baudRate);
        }

        private void btn_Read_Click(object sender, EventArgs e)
        {
            uint value = 0;

            string dummy;

            rs232.Read_A(out dummy, ref value);

            txtb_A_readData.Text = dummy;

            lbl_A_numsBytesToRead.Text = "NumsBytesToRead : "+ dummy.Length.ToString();
        }
        private void readLiveData(object sender, EventArgs e)
        {
            uint value = 0;

            string dummy = "";



            if (rs232.GetBuferSize_A() > 0)
            {
                rs232.Read_A(out dummy, ref value);
                txtb_A_readData.AppendText(Environment.NewLine + dummy);
            }
            lbl_A_numsBytesToRead.Text = "NumsBytesToRead : " + dummy.Length.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_A_readLive.Checked == true)
            {
                btn_Read.Enabled = false;

                timer.Interval = ts.Milliseconds;
                timer.Tick += readLiveData;
                timer.Start();
                cb_A_readLive.Text = "Live Stream ON";
            }
            else
            {
                cb_A_readLive.Text = "Live Stream OFF";
                btn_Read.Enabled = true;
                timer.Stop();
            }
        }
        #endregion


        #region rs232 Port B
        private void btn_Open_B_Click(object sender, EventArgs e)
        {
            string statusCode = rs232.OpenEx_B();
            if (statusCode.Equals("Success"))
            {
                groupBox4.Enabled = true;

                lbl_rs232_status_B.Text = "Status : Success";
                btn_rs232_close_B.Enabled = true;

                btn_rs232_close_B.BackColor = Color.FromArgb(230, 72, 72);
            }
            else
            {
                groupBox3.Enabled = false;
                btn_Open_B.Text = "Connection ERROR Try Again";
                lbl_rs232_status_B.Text = "Status : Failed";

            }
        }

        private void btn_rs232_close_B_Click(object sender, EventArgs e)
        {
            rs232.Close_B();
            groupBox4.Enabled = false;
        }

        private void btn_SetBaudRate_B_Click(object sender, EventArgs e)
        {
            uint tmp = uint.Parse(cBox_BitPerSecond_B.SelectedItem.ToString());
            uint baudRate = tmp;

            rs232.SetBaudRate_B(baudRate);
        }

        private void btn_SetDataChar_B_Click(object sender, EventArgs e)
        {
            byte dataBits = (byte)(int.Parse(cBox_DataBits_B.SelectedItem.ToString()));

            byte stopBit;
            int tempStop = (byte)(int.Parse(cBox_StopBits_B.SelectedItem.ToString()));
            if (tempStop == 1)
            {
                stopBit = (byte)0;
            }
            else
            {
                stopBit = (byte)2;
            }
            rs232.SetDataCharacteristics_B(dataBits, stopBit, SelectedParity());
        }

        private void btn_SetTimeout_B_Click(object sender, EventArgs e)
        {
            uint readTimeOut = (uint)(int)nud_SetTimeout_rto_B.Value;
            uint writeTimeout = (uint)(int)nud_SetTimeout_wto_B.Value; ;

            rs232.SetTimeouts_B(readTimeOut, writeTimeout);
        }

        private void btn_Read_B_Click(object sender, EventArgs e)
        {
            uint value = 0;

            string dummy;

            rs232.Read_B(out dummy, ref value);

            txtb_B_readData.Text = dummy;

            lbl_B_numsBytesToRead.Text = "NumsBytesToRead : " + dummy.Length.ToString();

        }

        private void btn_Write_B_Click(object sender, EventArgs e)
        {
            string tmp = txtb_Write_DataBuffer_B.Text;
            byte[] bytes = Encoding.ASCII.GetBytes(tmp);

            int numBytesToWrite = (int)bytes.Length;

            uint value = 0;

            rs232.Write_B(bytes, numBytesToWrite, ref value);
        }
        private void readLiveData_B(object sender, EventArgs e)
        {
            uint value = 0;

            string dummy = "";

            if (rs232.GetBuferSize_B() > 0)
            {
                rs232.Read_B(out dummy, ref value);
                txtb_B_readData.AppendText(Environment.NewLine + dummy);
            }

            lbl_B_numsBytesToRead.Text = "NumsBytesToRead : " + dummy.Length.ToString();
        }
        private void cb_B_readLive_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_B_readLive.Checked == true)
            {
                btn_Read_B.Enabled = false;

                timer.Interval = ts.Milliseconds;
                timer.Tick += readLiveData_B;
                timer.Start();
                cb_B_readLive.Text = "Live Stream ON";
            }
            else
            {
                cb_B_readLive.Text = "Live Stream OFF";
                btn_Read_B.Enabled = true;
                timer.Stop();
            }
        }

        #endregion
    }
}