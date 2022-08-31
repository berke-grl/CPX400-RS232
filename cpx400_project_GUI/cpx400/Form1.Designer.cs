

namespace cpx400
{
    partial class Form1
    {

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_Connect = new System.Windows.Forms.Button();
            this.btn_COE = new System.Windows.Forms.Button();
            this.btn_CCL = new System.Windows.Forms.Button();
            this.btn_COVP = new System.Windows.Forms.Button();
            this.btn_CVL = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_CVLchName = new System.Windows.Forms.Label();
            this.lbl_CVLlvl = new System.Windows.Forms.Label();
            this.nud_CVL_level = new System.Windows.Forms.NumericUpDown();
            this.lbl_CCLlimit = new System.Windows.Forms.Label();
            this.nud_CCL_limit = new System.Windows.Forms.NumericUpDown();
            this.lbl_COVPlimit = new System.Windows.Forms.Label();
            this.nud_COVP_limit = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nud_COCP_limit = new System.Windows.Forms.NumericUpDown();
            this.btn_COCP = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtn_voltage = new System.Windows.Forms.RadioButton();
            this.rbtn_amper = new System.Windows.Forms.RadioButton();
            this.lbl_chanelName = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.rbtn_COVP_true = new System.Windows.Forms.RadioButton();
            this.rbtn_COVP_false = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.nud_CCL_behavior = new System.Windows.Forms.NumericUpDown();
            this.gb_chanelNames = new System.Windows.Forms.GroupBox();
            this.rbtn_chname1 = new System.Windows.Forms.RadioButton();
            this.rbtn_chname2 = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_rs232_close_B = new System.Windows.Forms.Button();
            this.lbl_rs232_status_B = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cb_B_readLive = new System.Windows.Forms.CheckBox();
            this.lbl_B_numsBytesToRead = new System.Windows.Forms.Label();
            this.txtb_B_readData = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.btn_Read_B = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_SetBaudRate_B = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.cBox_StopBits_B = new System.Windows.Forms.ComboBox();
            this.btn_SetDataChar_B = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.nud_SetTimeout_wto_B = new System.Windows.Forms.NumericUpDown();
            this.cBox_Parity_B = new System.Windows.Forms.ComboBox();
            this.nud_SetTimeout_rto_B = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cBox_DataBits_B = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cBox_BitPerSecond_B = new System.Windows.Forms.ComboBox();
            this.btn_Write_B = new System.Windows.Forms.Button();
            this.btn_SetTimeout_B = new System.Windows.Forms.Button();
            this.txtb_Write_DataBuffer_B = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.btn_Open_B = new System.Windows.Forms.Button();
            this.btn_rs232_close_A = new System.Windows.Forms.Button();
            this.lbl_rs232_status_A = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cb_A_readLive = new System.Windows.Forms.CheckBox();
            this.lbl_A_numsBytesToRead = new System.Windows.Forms.Label();
            this.txtb_A_readData = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.btn_Read = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_SetBaudRate_A = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.cBox_StopBits_A = new System.Windows.Forms.ComboBox();
            this.btn_SetDataChar_A = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.nud_SetTimeout_wto_A = new System.Windows.Forms.NumericUpDown();
            this.cBox_Parity_A = new System.Windows.Forms.ComboBox();
            this.nud_SetTimeout_rto_A = new System.Windows.Forms.NumericUpDown();
            this.label21 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cBox_DataBits_A = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.cBox_BitPerSecond_A = new System.Windows.Forms.ComboBox();
            this.btn_Write = new System.Windows.Forms.Button();
            this.btn_SetTimeout_A = new System.Windows.Forms.Button();
            this.txtb_Write_DataBuffer_A = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_Open_A = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_CVL_level)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_CCL_limit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_COVP_limit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_COCP_limit)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_CCL_behavior)).BeginInit();
            this.gb_chanelNames.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_SetTimeout_wto_B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_SetTimeout_rto_B)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_SetTimeout_wto_A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_SetTimeout_rto_A)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Connect
            // 
            this.btn_Connect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(179)))), ((int)(((byte)(24)))));
            this.btn_Connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Connect.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Connect.ForeColor = System.Drawing.Color.White;
            this.btn_Connect.Location = new System.Drawing.Point(119, 0);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(877, 42);
            this.btn_Connect.TabIndex = 0;
            this.btn_Connect.Text = "CONNECT . . . ";
            this.btn_Connect.UseVisualStyleBackColor = false;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // btn_COE
            // 
            this.btn_COE.BackColor = System.Drawing.Color.White;
            this.btn_COE.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_COE.Location = new System.Drawing.Point(9, 280);
            this.btn_COE.Name = "btn_COE";
            this.btn_COE.Size = new System.Drawing.Size(259, 215);
            this.btn_COE.TabIndex = 1;
            this.btn_COE.Text = " Output Enabled/Disabled Configuration";
            this.btn_COE.UseVisualStyleBackColor = false;
            this.btn_COE.Click += new System.EventHandler(this.btn_COE_Click);
            // 
            // btn_CCL
            // 
            this.btn_CCL.BackColor = System.Drawing.Color.White;
            this.btn_CCL.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_CCL.Location = new System.Drawing.Point(27, 206);
            this.btn_CCL.Name = "btn_CCL";
            this.btn_CCL.Size = new System.Drawing.Size(221, 52);
            this.btn_CCL.TabIndex = 3;
            this.btn_CCL.Text = "Configure Current Limit";
            this.btn_CCL.UseVisualStyleBackColor = false;
            this.btn_CCL.Click += new System.EventHandler(this.btn_CCL_Click);
            // 
            // btn_COVP
            // 
            this.btn_COVP.BackColor = System.Drawing.Color.White;
            this.btn_COVP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_COVP.Location = new System.Drawing.Point(391, 455);
            this.btn_COVP.Name = "btn_COVP";
            this.btn_COVP.Size = new System.Drawing.Size(217, 52);
            this.btn_COVP.TabIndex = 4;
            this.btn_COVP.Text = " Configure OVP";
            this.btn_COVP.UseVisualStyleBackColor = false;
            this.btn_COVP.Click += new System.EventHandler(this.btn_COVP_Click);
            // 
            // btn_CVL
            // 
            this.btn_CVL.BackColor = System.Drawing.Color.White;
            this.btn_CVL.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_CVL.Location = new System.Drawing.Point(391, 280);
            this.btn_CVL.Name = "btn_CVL";
            this.btn_CVL.Size = new System.Drawing.Size(222, 52);
            this.btn_CVL.TabIndex = 5;
            this.btn_CVL.Text = "Configure Voltage Level";
            this.btn_CVL.UseVisualStyleBackColor = false;
            this.btn_CVL.Click += new System.EventHandler(this.btn_CVL_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_close.Enabled = false;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_close.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_close.Image = global::cpx400.Properties.Resources.close1;
            this.btn_close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_close.Location = new System.Drawing.Point(400, 63);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(242, 42);
            this.btn_close.TabIndex = 6;
            this.btn_close.Text = "CLOSE";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_reset.Enabled = false;
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_reset.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_reset.Image = global::cpx400.Properties.Resources.refresh_button;
            this.btn_reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reset.Location = new System.Drawing.Point(400, 111);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(243, 42);
            this.btn_reset.TabIndex = 7;
            this.btn_reset.Text = "RESET";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(400, 45);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(79, 15);
            this.lbl_status.TabIndex = 10;
            this.lbl_status.Text = "Status Code :";
            // 
            // lbl_CVLchName
            // 
            this.lbl_CVLchName.AutoSize = true;
            this.lbl_CVLchName.Location = new System.Drawing.Point(25, 22);
            this.lbl_CVLchName.Name = "lbl_CVLchName";
            this.lbl_CVLchName.Size = new System.Drawing.Size(88, 15);
            this.lbl_CVLchName.TabIndex = 12;
            this.lbl_CVLchName.Text = "Chanel Name : ";
            // 
            // lbl_CVLlvl
            // 
            this.lbl_CVLlvl.AutoSize = true;
            this.lbl_CVLlvl.Location = new System.Drawing.Point(391, 243);
            this.lbl_CVLlvl.Name = "lbl_CVLlvl";
            this.lbl_CVLlvl.Size = new System.Drawing.Size(69, 25);
            this.lbl_CVLlvl.TabIndex = 13;
            this.lbl_CVLlvl.Text = "Level : ";
            // 
            // nud_CVL_level
            // 
            this.nud_CVL_level.Location = new System.Drawing.Point(493, 241);
            this.nud_CVL_level.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nud_CVL_level.Name = "nud_CVL_level";
            this.nud_CVL_level.Size = new System.Drawing.Size(120, 33);
            this.nud_CVL_level.TabIndex = 16;
            // 
            // lbl_CCLlimit
            // 
            this.lbl_CCLlimit.AutoSize = true;
            this.lbl_CCLlimit.Location = new System.Drawing.Point(36, 128);
            this.lbl_CCLlimit.Name = "lbl_CCLlimit";
            this.lbl_CCLlimit.Size = new System.Drawing.Size(62, 25);
            this.lbl_CCLlimit.TabIndex = 18;
            this.lbl_CCLlimit.Text = "Limit :";
            // 
            // nud_CCL_limit
            // 
            this.nud_CCL_limit.DecimalPlaces = 2;
            this.nud_CCL_limit.Location = new System.Drawing.Point(128, 126);
            this.nud_CCL_limit.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nud_CCL_limit.Name = "nud_CCL_limit";
            this.nud_CCL_limit.Size = new System.Drawing.Size(120, 33);
            this.nud_CCL_limit.TabIndex = 20;
            // 
            // lbl_COVPlimit
            // 
            this.lbl_COVPlimit.AutoSize = true;
            this.lbl_COVPlimit.Location = new System.Drawing.Point(393, 418);
            this.lbl_COVPlimit.Name = "lbl_COVPlimit";
            this.lbl_COVPlimit.Size = new System.Drawing.Size(67, 25);
            this.lbl_COVPlimit.TabIndex = 22;
            this.lbl_COVPlimit.Text = "Limit : ";
            // 
            // nud_COVP_limit
            // 
            this.nud_COVP_limit.DecimalPlaces = 2;
            this.nud_COVP_limit.Location = new System.Drawing.Point(486, 416);
            this.nud_COVP_limit.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nud_COVP_limit.Name = "nud_COVP_limit";
            this.nud_COVP_limit.Size = new System.Drawing.Size(124, 33);
            this.nud_COVP_limit.TabIndex = 29;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(289, 103);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(91)))), ((int)(((byte)(100)))));
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nud_COCP_limit);
            this.groupBox1.Controls.Add(this.btn_COCP);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.lbl_chanelName);
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.groupBox8);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nud_CCL_behavior);
            this.groupBox1.Controls.Add(this.nud_COVP_limit);
            this.groupBox1.Controls.Add(this.lbl_CCLlimit);
            this.groupBox1.Controls.Add(this.nud_CCL_limit);
            this.groupBox1.Controls.Add(this.lbl_CVLlvl);
            this.groupBox1.Controls.Add(this.nud_CVL_level);
            this.groupBox1.Controls.Add(this.btn_CCL);
            this.groupBox1.Controls.Add(this.lbl_COVPlimit);
            this.groupBox1.Controls.Add(this.btn_CVL);
            this.groupBox1.Controls.Add(this.btn_COVP);
            this.groupBox1.Controls.Add(this.btn_COE);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.Silver;
            this.groupBox1.Location = new System.Drawing.Point(27, 251);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1059, 516);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CONTROLLER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(758, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 25);
            this.label3.TabIndex = 48;
            this.label3.Text = "measurement";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(393, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 51;
            this.label2.Text = "Limit :";
            // 
            // nud_COCP_limit
            // 
            this.nud_COCP_limit.DecimalPlaces = 2;
            this.nud_COCP_limit.Location = new System.Drawing.Point(490, 126);
            this.nud_COCP_limit.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nud_COCP_limit.Name = "nud_COCP_limit";
            this.nud_COCP_limit.Size = new System.Drawing.Size(120, 33);
            this.nud_COCP_limit.TabIndex = 52;
            // 
            // btn_COCP
            // 
            this.btn_COCP.BackColor = System.Drawing.Color.White;
            this.btn_COCP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_COCP.Location = new System.Drawing.Point(391, 165);
            this.btn_COCP.Name = "btn_COCP";
            this.btn_COCP.Size = new System.Drawing.Size(219, 52);
            this.btn_COCP.TabIndex = 50;
            this.btn_COCP.Text = " Configure OCP";
            this.btn_COCP.UseVisualStyleBackColor = false;
            this.btn_COCP.Click += new System.EventHandler(this.btn_COCP_click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtn_voltage);
            this.groupBox2.Controls.Add(this.rbtn_amper);
            this.groupBox2.ForeColor = System.Drawing.Color.Silver;
            this.groupBox2.Location = new System.Drawing.Point(758, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(284, 72);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Measurement Type";
            // 
            // rbtn_voltage
            // 
            this.rbtn_voltage.AutoSize = true;
            this.rbtn_voltage.Location = new System.Drawing.Point(34, 22);
            this.rbtn_voltage.Name = "rbtn_voltage";
            this.rbtn_voltage.Size = new System.Drawing.Size(118, 29);
            this.rbtn_voltage.TabIndex = 50;
            this.rbtn_voltage.Text = "Voltage(V)";
            this.rbtn_voltage.UseVisualStyleBackColor = true;
            // 
            // rbtn_amper
            // 
            this.rbtn_amper.AutoSize = true;
            this.rbtn_amper.Checked = true;
            this.rbtn_amper.Location = new System.Drawing.Point(158, 24);
            this.rbtn_amper.Name = "rbtn_amper";
            this.rbtn_amper.Size = new System.Drawing.Size(103, 29);
            this.rbtn_amper.TabIndex = 51;
            this.rbtn_amper.TabStop = true;
            this.rbtn_amper.Text = "Amper(I)";
            this.rbtn_amper.UseVisualStyleBackColor = true;
            // 
            // lbl_chanelName
            // 
            this.lbl_chanelName.AutoSize = true;
            this.lbl_chanelName.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_chanelName.ForeColor = System.Drawing.Color.SeaShell;
            this.lbl_chanelName.Location = new System.Drawing.Point(308, 0);
            this.lbl_chanelName.Name = "lbl_chanelName";
            this.lbl_chanelName.Size = new System.Drawing.Size(398, 47);
            this.lbl_chanelName.TabIndex = 48;
            this.lbl_chanelName.Text = "SELECTED CHANEL = 1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.richTextBox1.Location = new System.Drawing.Point(758, 261);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.richTextBox1.Size = new System.Drawing.Size(284, 234);
            this.richTextBox1.TabIndex = 46;
            this.richTextBox1.Text = "History";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.rbtn_COVP_true);
            this.groupBox8.Controls.Add(this.rbtn_COVP_false);
            this.groupBox8.ForeColor = System.Drawing.Color.Silver;
            this.groupBox8.Location = new System.Drawing.Point(393, 340);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(220, 61);
            this.groupBox8.TabIndex = 45;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Enabled";
            // 
            // rbtn_COVP_true
            // 
            this.rbtn_COVP_true.AutoSize = true;
            this.rbtn_COVP_true.Location = new System.Drawing.Point(70, 21);
            this.rbtn_COVP_true.Name = "rbtn_COVP_true";
            this.rbtn_COVP_true.Size = new System.Drawing.Size(66, 29);
            this.rbtn_COVP_true.TabIndex = 33;
            this.rbtn_COVP_true.Text = "True";
            this.rbtn_COVP_true.UseVisualStyleBackColor = true;
            // 
            // rbtn_COVP_false
            // 
            this.rbtn_COVP_false.AutoSize = true;
            this.rbtn_COVP_false.Checked = true;
            this.rbtn_COVP_false.Location = new System.Drawing.Point(142, 21);
            this.rbtn_COVP_false.Name = "rbtn_COVP_false";
            this.rbtn_COVP_false.Size = new System.Drawing.Size(71, 29);
            this.rbtn_COVP_false.TabIndex = 34;
            this.rbtn_COVP_false.TabStop = true;
            this.rbtn_COVP_false.Text = "False";
            this.rbtn_COVP_false.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 43;
            this.label1.Text = "Behavior :";
            // 
            // nud_CCL_behavior
            // 
            this.nud_CCL_behavior.DecimalPlaces = 2;
            this.nud_CCL_behavior.Location = new System.Drawing.Point(128, 165);
            this.nud_CCL_behavior.Name = "nud_CCL_behavior";
            this.nud_CCL_behavior.Size = new System.Drawing.Size(120, 33);
            this.nud_CCL_behavior.TabIndex = 44;
            // 
            // gb_chanelNames
            // 
            this.gb_chanelNames.Controls.Add(this.rbtn_chname1);
            this.gb_chanelNames.Controls.Add(this.rbtn_chname2);
            this.gb_chanelNames.Enabled = false;
            this.gb_chanelNames.Location = new System.Drawing.Point(400, 159);
            this.gb_chanelNames.Name = "gb_chanelNames";
            this.gb_chanelNames.Size = new System.Drawing.Size(269, 86);
            this.gb_chanelNames.TabIndex = 47;
            this.gb_chanelNames.TabStop = false;
            this.gb_chanelNames.Text = "Chanel Name";
            // 
            // rbtn_chname1
            // 
            this.rbtn_chname1.AutoSize = true;
            this.rbtn_chname1.Checked = true;
            this.rbtn_chname1.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbtn_chname1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.rbtn_chname1.Location = new System.Drawing.Point(42, 20);
            this.rbtn_chname1.Name = "rbtn_chname1";
            this.rbtn_chname1.Size = new System.Drawing.Size(48, 41);
            this.rbtn_chname1.TabIndex = 37;
            this.rbtn_chname1.TabStop = true;
            this.rbtn_chname1.Text = "1";
            this.rbtn_chname1.UseVisualStyleBackColor = true;
            this.rbtn_chname1.CheckedChanged += new System.EventHandler(this.rbtn_chname1_CheckedChanged);
            // 
            // rbtn_chname2
            // 
            this.rbtn_chname2.AutoSize = true;
            this.rbtn_chname2.Checked = true;
            this.rbtn_chname2.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbtn_chname2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.rbtn_chname2.Location = new System.Drawing.Point(157, 20);
            this.rbtn_chname2.Name = "rbtn_chname2";
            this.rbtn_chname2.Size = new System.Drawing.Size(51, 41);
            this.rbtn_chname2.TabIndex = 36;
            this.rbtn_chname2.TabStop = true;
            this.rbtn_chname2.Text = "2";
            this.rbtn_chname2.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(32, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1139, 817);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 48;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.tabPage1.Controls.Add(this.btn_Connect);
            this.tabPage1.Controls.Add(this.gb_chanelNames);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btn_reset);
            this.tabPage1.Controls.Add(this.lbl_status);
            this.tabPage1.Controls.Add(this.btn_close);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1131, 789);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "CPX400";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(70)))), ((int)(((byte)(53)))));
            this.tabPage2.Controls.Add(this.btn_rs232_close_B);
            this.tabPage2.Controls.Add(this.lbl_rs232_status_B);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.btn_Open_B);
            this.tabPage2.Controls.Add(this.btn_rs232_close_A);
            this.tabPage2.Controls.Add(this.lbl_rs232_status_A);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.btn_Open_A);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1131, 789);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "RS232";
            // 
            // btn_rs232_close_B
            // 
            this.btn_rs232_close_B.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_rs232_close_B.Enabled = false;
            this.btn_rs232_close_B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rs232_close_B.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_rs232_close_B.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_rs232_close_B.Image = global::cpx400.Properties.Resources.close1;
            this.btn_rs232_close_B.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_rs232_close_B.Location = new System.Drawing.Point(737, 99);
            this.btn_rs232_close_B.Name = "btn_rs232_close_B";
            this.btn_rs232_close_B.Size = new System.Drawing.Size(242, 42);
            this.btn_rs232_close_B.TabIndex = 103;
            this.btn_rs232_close_B.Text = "CLOSE (PORT B)";
            this.btn_rs232_close_B.UseVisualStyleBackColor = false;
            this.btn_rs232_close_B.Click += new System.EventHandler(this.btn_rs232_close_B_Click);
            // 
            // lbl_rs232_status_B
            // 
            this.lbl_rs232_status_B.AutoSize = true;
            this.lbl_rs232_status_B.Location = new System.Drawing.Point(737, 81);
            this.lbl_rs232_status_B.Name = "lbl_rs232_status_B";
            this.lbl_rs232_status_B.Size = new System.Drawing.Size(51, 15);
            this.lbl_rs232_status_B.TabIndex = 102;
            this.lbl_rs232_status_B.Text = "Status : ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cb_B_readLive);
            this.groupBox4.Controls.Add(this.lbl_B_numsBytesToRead);
            this.groupBox4.Controls.Add(this.txtb_B_readData);
            this.groupBox4.Controls.Add(this.label26);
            this.groupBox4.Controls.Add(this.btn_Read_B);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.btn_SetBaudRate_B);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.cBox_StopBits_B);
            this.groupBox4.Controls.Add(this.btn_SetDataChar_B);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.nud_SetTimeout_wto_B);
            this.groupBox4.Controls.Add(this.cBox_Parity_B);
            this.groupBox4.Controls.Add(this.nud_SetTimeout_rto_B);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.cBox_DataBits_B);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.cBox_BitPerSecond_B);
            this.groupBox4.Controls.Add(this.btn_Write_B);
            this.groupBox4.Controls.Add(this.btn_SetTimeout_B);
            this.groupBox4.Controls.Add(this.txtb_Write_DataBuffer_B);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Enabled = false;
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox4.Location = new System.Drawing.Point(589, 147);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(504, 623);
            this.groupBox4.TabIndex = 101;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "PORT B CONTROLLER";
            // 
            // cb_B_readLive
            // 
            this.cb_B_readLive.AutoSize = true;
            this.cb_B_readLive.Location = new System.Drawing.Point(264, 368);
            this.cb_B_readLive.Name = "cb_B_readLive";
            this.cb_B_readLive.Size = new System.Drawing.Size(88, 19);
            this.cb_B_readLive.TabIndex = 110;
            this.cb_B_readLive.Text = "Live Steam";
            this.cb_B_readLive.UseVisualStyleBackColor = true;
            this.cb_B_readLive.CheckedChanged += new System.EventHandler(this.cb_B_readLive_CheckedChanged);
            // 
            // lbl_B_numsBytesToRead
            // 
            this.lbl_B_numsBytesToRead.AutoSize = true;
            this.lbl_B_numsBytesToRead.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(238)))), ((int)(((byte)(169)))));
            this.lbl_B_numsBytesToRead.Location = new System.Drawing.Point(258, 599);
            this.lbl_B_numsBytesToRead.Name = "lbl_B_numsBytesToRead";
            this.lbl_B_numsBytesToRead.Size = new System.Drawing.Size(120, 15);
            this.lbl_B_numsBytesToRead.TabIndex = 109;
            this.lbl_B_numsBytesToRead.Text = "NumsBytesToRead : ";
            // 
            // txtb_B_readData
            // 
            this.txtb_B_readData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtb_B_readData.Location = new System.Drawing.Point(258, 406);
            this.txtb_B_readData.Multiline = true;
            this.txtb_B_readData.Name = "txtb_B_readData";
            this.txtb_B_readData.ReadOnly = true;
            this.txtb_B_readData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtb_B_readData.Size = new System.Drawing.Size(234, 135);
            this.txtb_B_readData.TabIndex = 108;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label26.ForeColor = System.Drawing.Color.SeaShell;
            this.label26.Location = new System.Drawing.Point(98, 41);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(320, 47);
            this.label26.TabIndex = 106;
            this.label26.Text = "PORT B SETTINGS";
            // 
            // btn_Read_B
            // 
            this.btn_Read_B.Location = new System.Drawing.Point(258, 547);
            this.btn_Read_B.Name = "btn_Read_B";
            this.btn_Read_B.Size = new System.Drawing.Size(234, 49);
            this.btn_Read_B.TabIndex = 104;
            this.btn_Read_B.Text = "Read";
            this.btn_Read_B.UseVisualStyleBackColor = true;
            this.btn_Read_B.Click += new System.EventHandler(this.btn_Read_B_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(238)))), ((int)(((byte)(169)))));
            this.label10.Location = new System.Drawing.Point(326, 383);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 20);
            this.label10.TabIndex = 103;
            this.label10.Text = "Data Buffer :";
            // 
            // btn_SetBaudRate_B
            // 
            this.btn_SetBaudRate_B.Location = new System.Drawing.Point(148, 139);
            this.btn_SetBaudRate_B.Name = "btn_SetBaudRate_B";
            this.btn_SetBaudRate_B.Size = new System.Drawing.Size(225, 49);
            this.btn_SetBaudRate_B.TabIndex = 97;
            this.btn_SetBaudRate_B.Text = "SetBaudRate";
            this.btn_SetBaudRate_B.UseVisualStyleBackColor = true;
            this.btn_SetBaudRate_B.Click += new System.EventHandler(this.btn_SetBaudRate_B_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(238)))), ((int)(((byte)(169)))));
            this.label11.Location = new System.Drawing.Point(38, 280);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 20);
            this.label11.TabIndex = 96;
            this.label11.Text = "Stop bits";
            // 
            // cBox_StopBits_B
            // 
            this.cBox_StopBits_B.FormattingEnabled = true;
            this.cBox_StopBits_B.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cBox_StopBits_B.Location = new System.Drawing.Point(142, 284);
            this.cBox_StopBits_B.Name = "cBox_StopBits_B";
            this.cBox_StopBits_B.Size = new System.Drawing.Size(82, 23);
            this.cBox_StopBits_B.TabIndex = 95;
            this.cBox_StopBits_B.Text = "1";
            // 
            // btn_SetDataChar_B
            // 
            this.btn_SetDataChar_B.Location = new System.Drawing.Point(30, 313);
            this.btn_SetDataChar_B.Name = "btn_SetDataChar_B";
            this.btn_SetDataChar_B.Size = new System.Drawing.Size(194, 49);
            this.btn_SetDataChar_B.TabIndex = 51;
            this.btn_SetDataChar_B.Text = "SetDataCharacteristics";
            this.btn_SetDataChar_B.UseVisualStyleBackColor = true;
            this.btn_SetDataChar_B.Click += new System.EventHandler(this.btn_SetDataChar_B_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(238)))), ((int)(((byte)(169)))));
            this.label14.Location = new System.Drawing.Point(54, 254);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 20);
            this.label14.TabIndex = 94;
            this.label14.Text = "Parity :";
            // 
            // nud_SetTimeout_wto_B
            // 
            this.nud_SetTimeout_wto_B.Location = new System.Drawing.Point(393, 284);
            this.nud_SetTimeout_wto_B.Name = "nud_SetTimeout_wto_B";
            this.nud_SetTimeout_wto_B.Size = new System.Drawing.Size(99, 23);
            this.nud_SetTimeout_wto_B.TabIndex = 58;
            // 
            // cBox_Parity_B
            // 
            this.cBox_Parity_B.FormattingEnabled = true;
            this.cBox_Parity_B.Items.AddRange(new object[] {
            "Even",
            "Odd",
            "None",
            "Mark",
            "Space"});
            this.cBox_Parity_B.Location = new System.Drawing.Point(142, 255);
            this.cBox_Parity_B.Name = "cBox_Parity_B";
            this.cBox_Parity_B.Size = new System.Drawing.Size(82, 23);
            this.cBox_Parity_B.TabIndex = 93;
            this.cBox_Parity_B.Text = "None";
            // 
            // nud_SetTimeout_rto_B
            // 
            this.nud_SetTimeout_rto_B.Location = new System.Drawing.Point(393, 253);
            this.nud_SetTimeout_rto_B.Name = "nud_SetTimeout_rto_B";
            this.nud_SetTimeout_rto_B.Size = new System.Drawing.Size(99, 23);
            this.nud_SetTimeout_rto_B.TabIndex = 59;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(238)))), ((int)(((byte)(169)))));
            this.label15.Location = new System.Drawing.Point(30, 226);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 20);
            this.label15.TabIndex = 92;
            this.label15.Text = "Data bits :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(238)))), ((int)(((byte)(169)))));
            this.label16.Location = new System.Drawing.Point(264, 253);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(115, 20);
            this.label16.TabIndex = 60;
            this.label16.Text = "Read Time Out :";
            // 
            // cBox_DataBits_B
            // 
            this.cBox_DataBits_B.FormattingEnabled = true;
            this.cBox_DataBits_B.Items.AddRange(new object[] {
            "8",
            "7"});
            this.cBox_DataBits_B.Location = new System.Drawing.Point(142, 226);
            this.cBox_DataBits_B.Name = "cBox_DataBits_B";
            this.cBox_DataBits_B.Size = new System.Drawing.Size(82, 23);
            this.cBox_DataBits_B.TabIndex = 91;
            this.cBox_DataBits_B.Text = "8";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(238)))), ((int)(((byte)(169)))));
            this.label17.Location = new System.Drawing.Point(264, 284);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(117, 20);
            this.label17.TabIndex = 61;
            this.label17.Text = "Write Time Out :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(238)))), ((int)(((byte)(169)))));
            this.label18.Location = new System.Drawing.Point(148, 109);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(117, 20);
            this.label18.TabIndex = 90;
            this.label18.Text = "Bits per second :";
            // 
            // cBox_BitPerSecond_B
            // 
            this.cBox_BitPerSecond_B.FormattingEnabled = true;
            this.cBox_BitPerSecond_B.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "1800",
            "2400",
            "4800",
            "7200",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200",
            "230400",
            "460800",
            "921600"});
            this.cBox_BitPerSecond_B.Location = new System.Drawing.Point(277, 109);
            this.cBox_BitPerSecond_B.Name = "cBox_BitPerSecond_B";
            this.cBox_BitPerSecond_B.Size = new System.Drawing.Size(96, 23);
            this.cBox_BitPerSecond_B.TabIndex = 89;
            this.cBox_BitPerSecond_B.Text = "9600";
            // 
            // btn_Write_B
            // 
            this.btn_Write_B.Location = new System.Drawing.Point(13, 547);
            this.btn_Write_B.Name = "btn_Write_B";
            this.btn_Write_B.Size = new System.Drawing.Size(228, 49);
            this.btn_Write_B.TabIndex = 88;
            this.btn_Write_B.Text = "Write";
            this.btn_Write_B.UseVisualStyleBackColor = true;
            this.btn_Write_B.Click += new System.EventHandler(this.btn_Write_B_Click);
            // 
            // btn_SetTimeout_B
            // 
            this.btn_SetTimeout_B.Location = new System.Drawing.Point(264, 313);
            this.btn_SetTimeout_B.Name = "btn_SetTimeout_B";
            this.btn_SetTimeout_B.Size = new System.Drawing.Size(228, 49);
            this.btn_SetTimeout_B.TabIndex = 87;
            this.btn_SetTimeout_B.Text = "SetTimeout";
            this.btn_SetTimeout_B.UseVisualStyleBackColor = true;
            this.btn_SetTimeout_B.Click += new System.EventHandler(this.btn_SetTimeout_B_Click);
            // 
            // txtb_Write_DataBuffer_B
            // 
            this.txtb_Write_DataBuffer_B.Location = new System.Drawing.Point(13, 518);
            this.txtb_Write_DataBuffer_B.Name = "txtb_Write_DataBuffer_B";
            this.txtb_Write_DataBuffer_B.Size = new System.Drawing.Size(228, 23);
            this.txtb_Write_DataBuffer_B.TabIndex = 70;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(238)))), ((int)(((byte)(169)))));
            this.label23.Location = new System.Drawing.Point(82, 495);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(92, 20);
            this.label23.TabIndex = 75;
            this.label23.Text = "Data Buffer :";
            // 
            // btn_Open_B
            // 
            this.btn_Open_B.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(179)))), ((int)(((byte)(24)))));
            this.btn_Open_B.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Open_B.Location = new System.Drawing.Point(589, 22);
            this.btn_Open_B.Name = "btn_Open_B";
            this.btn_Open_B.Size = new System.Drawing.Size(504, 56);
            this.btn_Open_B.TabIndex = 100;
            this.btn_Open_B.Text = "Open (PORT B)";
            this.btn_Open_B.UseVisualStyleBackColor = false;
            this.btn_Open_B.Click += new System.EventHandler(this.btn_Open_B_Click);
            // 
            // btn_rs232_close_A
            // 
            this.btn_rs232_close_A.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_rs232_close_A.Enabled = false;
            this.btn_rs232_close_A.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rs232_close_A.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_rs232_close_A.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_rs232_close_A.Image = global::cpx400.Properties.Resources.close1;
            this.btn_rs232_close_A.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_rs232_close_A.Location = new System.Drawing.Point(193, 99);
            this.btn_rs232_close_A.Name = "btn_rs232_close_A";
            this.btn_rs232_close_A.Size = new System.Drawing.Size(242, 42);
            this.btn_rs232_close_A.TabIndex = 99;
            this.btn_rs232_close_A.Text = "CLOSE (PORT A)";
            this.btn_rs232_close_A.UseVisualStyleBackColor = false;
            this.btn_rs232_close_A.Click += new System.EventHandler(this.btn_rs232_close_Click);
            // 
            // lbl_rs232_status_A
            // 
            this.lbl_rs232_status_A.AutoSize = true;
            this.lbl_rs232_status_A.Location = new System.Drawing.Point(193, 81);
            this.lbl_rs232_status_A.Name = "lbl_rs232_status_A";
            this.lbl_rs232_status_A.Size = new System.Drawing.Size(51, 15);
            this.lbl_rs232_status_A.TabIndex = 98;
            this.lbl_rs232_status_A.Text = "Status : ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cb_A_readLive);
            this.groupBox3.Controls.Add(this.lbl_A_numsBytesToRead);
            this.groupBox3.Controls.Add(this.txtb_A_readData);
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Controls.Add(this.btn_Read);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btn_SetBaudRate_A);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Controls.Add(this.cBox_StopBits_A);
            this.groupBox3.Controls.Add(this.btn_SetDataChar_A);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.nud_SetTimeout_wto_A);
            this.groupBox3.Controls.Add(this.cBox_Parity_A);
            this.groupBox3.Controls.Add(this.nud_SetTimeout_rto_A);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.cBox_DataBits_A);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.cBox_BitPerSecond_A);
            this.groupBox3.Controls.Add(this.btn_Write);
            this.groupBox3.Controls.Add(this.btn_SetTimeout_A);
            this.groupBox3.Controls.Add(this.txtb_Write_DataBuffer_A);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Enabled = false;
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox3.Location = new System.Drawing.Point(33, 147);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(504, 623);
            this.groupBox3.TabIndex = 97;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "PORT A CONTROLLER";
            // 
            // cb_A_readLive
            // 
            this.cb_A_readLive.AutoSize = true;
            this.cb_A_readLive.Location = new System.Drawing.Point(260, 365);
            this.cb_A_readLive.Name = "cb_A_readLive";
            this.cb_A_readLive.Size = new System.Drawing.Size(93, 19);
            this.cb_A_readLive.TabIndex = 109;
            this.cb_A_readLive.Text = "Live Stream";
            this.cb_A_readLive.UseVisualStyleBackColor = true;
            this.cb_A_readLive.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lbl_A_numsBytesToRead
            // 
            this.lbl_A_numsBytesToRead.AutoSize = true;
            this.lbl_A_numsBytesToRead.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(238)))), ((int)(((byte)(169)))));
            this.lbl_A_numsBytesToRead.Location = new System.Drawing.Point(259, 599);
            this.lbl_A_numsBytesToRead.Name = "lbl_A_numsBytesToRead";
            this.lbl_A_numsBytesToRead.Size = new System.Drawing.Size(120, 15);
            this.lbl_A_numsBytesToRead.TabIndex = 108;
            this.lbl_A_numsBytesToRead.Text = "NumsBytesToRead : ";
            // 
            // txtb_A_readData
            // 
            this.txtb_A_readData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtb_A_readData.Location = new System.Drawing.Point(262, 406);
            this.txtb_A_readData.Multiline = true;
            this.txtb_A_readData.Name = "txtb_A_readData";
            this.txtb_A_readData.ReadOnly = true;
            this.txtb_A_readData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtb_A_readData.Size = new System.Drawing.Size(225, 135);
            this.txtb_A_readData.TabIndex = 107;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label25.ForeColor = System.Drawing.Color.SeaShell;
            this.label25.Location = new System.Drawing.Point(101, 41);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(323, 47);
            this.label25.TabIndex = 105;
            this.label25.Text = "PORT A SETTINGS";
            // 
            // btn_Read
            // 
            this.btn_Read.Location = new System.Drawing.Point(259, 547);
            this.btn_Read.Name = "btn_Read";
            this.btn_Read.Size = new System.Drawing.Size(234, 49);
            this.btn_Read.TabIndex = 104;
            this.btn_Read.Text = "Read";
            this.btn_Read.UseVisualStyleBackColor = true;
            this.btn_Read.Click += new System.EventHandler(this.btn_Read_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(238)))), ((int)(((byte)(169)))));
            this.label6.Location = new System.Drawing.Point(332, 383);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 20);
            this.label6.TabIndex = 103;
            this.label6.Text = "Data Buffer :";
            // 
            // btn_SetBaudRate_A
            // 
            this.btn_SetBaudRate_A.Location = new System.Drawing.Point(146, 136);
            this.btn_SetBaudRate_A.Name = "btn_SetBaudRate_A";
            this.btn_SetBaudRate_A.Size = new System.Drawing.Size(225, 49);
            this.btn_SetBaudRate_A.TabIndex = 97;
            this.btn_SetBaudRate_A.Text = "SetBaudRate";
            this.btn_SetBaudRate_A.UseVisualStyleBackColor = true;
            this.btn_SetBaudRate_A.Click += new System.EventHandler(this.btn_SetBaudRate_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(238)))), ((int)(((byte)(169)))));
            this.label24.Location = new System.Drawing.Point(36, 277);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(68, 20);
            this.label24.TabIndex = 96;
            this.label24.Text = "Stop bits";
            // 
            // cBox_StopBits_A
            // 
            this.cBox_StopBits_A.FormattingEnabled = true;
            this.cBox_StopBits_A.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cBox_StopBits_A.Location = new System.Drawing.Point(140, 281);
            this.cBox_StopBits_A.Name = "cBox_StopBits_A";
            this.cBox_StopBits_A.Size = new System.Drawing.Size(82, 23);
            this.cBox_StopBits_A.TabIndex = 95;
            this.cBox_StopBits_A.Text = "1";
            // 
            // btn_SetDataChar_A
            // 
            this.btn_SetDataChar_A.Location = new System.Drawing.Point(28, 310);
            this.btn_SetDataChar_A.Name = "btn_SetDataChar_A";
            this.btn_SetDataChar_A.Size = new System.Drawing.Size(194, 49);
            this.btn_SetDataChar_A.TabIndex = 51;
            this.btn_SetDataChar_A.Text = "SetDataCharacteristics";
            this.btn_SetDataChar_A.UseVisualStyleBackColor = true;
            this.btn_SetDataChar_A.Click += new System.EventHandler(this.btn_SetDataChar_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(238)))), ((int)(((byte)(169)))));
            this.label22.Location = new System.Drawing.Point(52, 251);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(52, 20);
            this.label22.TabIndex = 94;
            this.label22.Text = "Parity :";
            // 
            // nud_SetTimeout_wto_A
            // 
            this.nud_SetTimeout_wto_A.Location = new System.Drawing.Point(388, 280);
            this.nud_SetTimeout_wto_A.Name = "nud_SetTimeout_wto_A";
            this.nud_SetTimeout_wto_A.Size = new System.Drawing.Size(99, 23);
            this.nud_SetTimeout_wto_A.TabIndex = 58;
            // 
            // cBox_Parity_A
            // 
            this.cBox_Parity_A.FormattingEnabled = true;
            this.cBox_Parity_A.Items.AddRange(new object[] {
            "Even",
            "Odd",
            "None",
            "Mark",
            "Space"});
            this.cBox_Parity_A.Location = new System.Drawing.Point(140, 252);
            this.cBox_Parity_A.Name = "cBox_Parity_A";
            this.cBox_Parity_A.Size = new System.Drawing.Size(82, 23);
            this.cBox_Parity_A.TabIndex = 93;
            this.cBox_Parity_A.Text = "None";
            // 
            // nud_SetTimeout_rto_A
            // 
            this.nud_SetTimeout_rto_A.Location = new System.Drawing.Point(388, 248);
            this.nud_SetTimeout_rto_A.Name = "nud_SetTimeout_rto_A";
            this.nud_SetTimeout_rto_A.Size = new System.Drawing.Size(99, 23);
            this.nud_SetTimeout_rto_A.TabIndex = 59;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(238)))), ((int)(((byte)(169)))));
            this.label21.Location = new System.Drawing.Point(28, 223);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(76, 20);
            this.label21.TabIndex = 92;
            this.label21.Text = "Data bits :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(238)))), ((int)(((byte)(169)))));
            this.label8.Location = new System.Drawing.Point(262, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 20);
            this.label8.TabIndex = 60;
            this.label8.Text = "Read Time Out :";
            // 
            // cBox_DataBits_A
            // 
            this.cBox_DataBits_A.FormattingEnabled = true;
            this.cBox_DataBits_A.Items.AddRange(new object[] {
            "8",
            "7"});
            this.cBox_DataBits_A.Location = new System.Drawing.Point(140, 223);
            this.cBox_DataBits_A.Name = "cBox_DataBits_A";
            this.cBox_DataBits_A.Size = new System.Drawing.Size(82, 23);
            this.cBox_DataBits_A.TabIndex = 91;
            this.cBox_DataBits_A.Text = "8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(238)))), ((int)(((byte)(169)))));
            this.label7.Location = new System.Drawing.Point(265, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 20);
            this.label7.TabIndex = 61;
            this.label7.Text = "Write Time Out :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(238)))), ((int)(((byte)(169)))));
            this.label20.Location = new System.Drawing.Point(146, 106);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(117, 20);
            this.label20.TabIndex = 90;
            this.label20.Text = "Bits per second :";
            // 
            // cBox_BitPerSecond_A
            // 
            this.cBox_BitPerSecond_A.FormattingEnabled = true;
            this.cBox_BitPerSecond_A.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "1800",
            "2400",
            "4800",
            "7200",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200",
            "230400",
            "460800",
            "921600"});
            this.cBox_BitPerSecond_A.Location = new System.Drawing.Point(275, 106);
            this.cBox_BitPerSecond_A.Name = "cBox_BitPerSecond_A";
            this.cBox_BitPerSecond_A.Size = new System.Drawing.Size(96, 23);
            this.cBox_BitPerSecond_A.TabIndex = 89;
            this.cBox_BitPerSecond_A.Text = "9600";
            // 
            // btn_Write
            // 
            this.btn_Write.Location = new System.Drawing.Point(6, 547);
            this.btn_Write.Name = "btn_Write";
            this.btn_Write.Size = new System.Drawing.Size(228, 49);
            this.btn_Write.TabIndex = 88;
            this.btn_Write.Text = "Write";
            this.btn_Write.UseVisualStyleBackColor = true;
            this.btn_Write.Click += new System.EventHandler(this.btn_write_Click);
            // 
            // btn_SetTimeout_A
            // 
            this.btn_SetTimeout_A.Location = new System.Drawing.Point(259, 310);
            this.btn_SetTimeout_A.Name = "btn_SetTimeout_A";
            this.btn_SetTimeout_A.Size = new System.Drawing.Size(228, 49);
            this.btn_SetTimeout_A.TabIndex = 87;
            this.btn_SetTimeout_A.Text = "SetTimeout";
            this.btn_SetTimeout_A.UseVisualStyleBackColor = true;
            this.btn_SetTimeout_A.Click += new System.EventHandler(this.btn_SetTimeout_Click);
            // 
            // txtb_Write_DataBuffer_A
            // 
            this.txtb_Write_DataBuffer_A.Location = new System.Drawing.Point(6, 518);
            this.txtb_Write_DataBuffer_A.Name = "txtb_Write_DataBuffer_A";
            this.txtb_Write_DataBuffer_A.Size = new System.Drawing.Size(228, 23);
            this.txtb_Write_DataBuffer_A.TabIndex = 70;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(238)))), ((int)(((byte)(169)))));
            this.label12.Location = new System.Drawing.Point(79, 495);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 20);
            this.label12.TabIndex = 75;
            this.label12.Text = "Data Buffer :";
            // 
            // btn_Open_A
            // 
            this.btn_Open_A.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(179)))), ((int)(((byte)(24)))));
            this.btn_Open_A.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Open_A.Location = new System.Drawing.Point(33, 22);
            this.btn_Open_A.Name = "btn_Open_A";
            this.btn_Open_A.Size = new System.Drawing.Size(504, 56);
            this.btn_Open_A.TabIndex = 50;
            this.btn_Open_A.Text = "Open (PORT A)";
            this.btn_Open_A.UseVisualStyleBackColor = false;
            this.btn_Open_A.Click += new System.EventHandler(this.btn_OpenEx_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1205, 854);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nud_CVL_level)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_CCL_limit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_COVP_limit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_COCP_limit)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_CCL_behavior)).EndInit();
            this.gb_chanelNames.ResumeLayout(false);
            this.gb_chanelNames.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_SetTimeout_wto_B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_SetTimeout_rto_B)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_SetTimeout_wto_A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_SetTimeout_rto_A)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_Connect;
        private Button btn_SetTimeout_A;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button btn_close;
        private Button btn_reset;
        private Label lbl_status;
        private Label lbl_CVLchName;
        private Label lbl_CVLlvl;
        private NumericUpDown nud_CVL_level;
        private Label lbl_CCLlimit;
        private NumericUpDown nud_CCL_limit;
        private Label lbl_COVPlimit;
        private NumericUpDown nud_COVP_limit;
        private PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBox1;
        private Button Enabled;
        private Button btn_COE;
        private Button btn_CCL;
        private Button btn_COVP;
        private Button btn_CVL;
        private Label label1;
        private NumericUpDown nud_CCL_behavior;
        private GroupBox groupBox8;
        private RadioButton rbtn_COVP_true;
        private RadioButton rbtn_COVP_false;
        private RichTextBox richTextBox1;
        private GroupBox gb_chanelNames;
        private RadioButton rbtn_chname1;
        private RadioButton rbtn_chname2;
        private Label lbl_chanelName;
        private GroupBox groupBox2;
        private RadioButton rbtn_voltage;
        private RadioButton rbtn_amper;
        private Button btn_COCP;
        private Label label2;
        private NumericUpDown nud_COCP_limit;
        private Label label3;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label12;
        private TextBox txtb_Write_DataBuffer_A;
        private Label label7;
        private Label label8;
        private NumericUpDown nud_SetTimeout_rto_A;
        private NumericUpDown nud_SetTimeout_wto_A;
        private Button btn_SetDataChar_A;
        private Button btn_Open_A;
        private Button btn_Write;
        private Label label24;
        private ComboBox cBox_StopBits_A;
        private Label label22;
        private ComboBox cBox_Parity_A;
        private Label label21;
        private ComboBox cBox_DataBits_A;
        private Label label20;
        private ComboBox cBox_BitPerSecond_A;
        private GroupBox groupBox3;
        private Label lbl_rs232_status_A;
        private Button btn_rs232_close_A;
        private Button btn_SetBaudRate_A;
        private Button btn_Read;
        private Label label6;
        private Button btn_rs232_close_B;
        private Label lbl_rs232_status_B;
        private GroupBox groupBox4;
        private Button btn_Read_B;
        private Label label10;
        private Button btn_SetBaudRate_B;
        private Label label11;
        private ComboBox cBox_StopBits_B;
        private Button btn_SetDataChar_B;
        private Label label14;
        private NumericUpDown nud_SetTimeout_wto_B;
        private ComboBox cBox_Parity_B;
        private NumericUpDown nud_SetTimeout_rto_B;
        private Label label15;
        private Label label16;
        private ComboBox cBox_DataBits_B;
        private Label label17;
        private Label label18;
        private ComboBox cBox_BitPerSecond_B;
        private Button btn_Write_B;
        private Button btn_SetTimeout_B;
        private TextBox txtb_Write_DataBuffer_B;
        private Label label23;
        private Button btn_Open_B;
        private Label label26;
        private Label label25;
        private Label lbl_A_readData;
        private TextBox txtb_A_readData;
        private TextBox txtb_B_readData;
        private Label lbl_B_numsBytesToRead;
        private Label lbl_A_numsBytesToRead;
        private CheckBox cb_A_readLive;
        private CheckBox cb_B_readLive;
    }
}