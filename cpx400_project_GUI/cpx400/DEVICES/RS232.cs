using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace cpx400.DEVICES
{
    public class RS232
    {

        FTD2XX_NET.FTDI rs232_A = new FTD2XX_NET.FTDI();
        FTD2XX_NET.FTDI rs232_B = new FTD2XX_NET.FTDI();
        public enum ViStatus
        {
            Success,
            Warnings,
            Errors,
            Null
        }
        #region PORT A SETTINGS

        public string OpenEx_A()
        {
            try
            {
                 var status = (ViStatus)rs232_A.OpenByIndex(0);
                 string isConnect =  status.ToString();
                if (isConnect.Equals("Success"))
                {
                    return "Success";
                }
                else
                {
                    return "Connection Error";
                }
               
            }
            catch (Exception e)
            {
                return e.ToString();
            }      
            
        }

        public void SetDataCharacteristics_A(byte DataBits, byte StopBits, byte Parity)
        {
            rs232_A.SetDataCharacteristics(DataBits, StopBits, Parity);
        }

        public void SetBaudRate_A( uint BaudRate)
        {
            rs232_A.SetBaudRate(BaudRate);

        }

        public void SetTimeouts_A(uint ReadTimeout, uint WriteTimeout)
        {
            var status = (ViStatus)rs232_A.SetTimeouts(ReadTimeout, WriteTimeout);
        }
        public void Write_A(byte[] dataBuffer, int numBytesToWrite, ref uint numBytesWritten)
        {
            rs232_A.Write(dataBuffer, numBytesToWrite, ref numBytesWritten);
        }
        public void Read_A(out string data, ref uint numBytesRead)
        {
            uint queue = 0;
             rs232_A.GetRxBytesAvailable(ref queue);

            rs232_A.Read(out data, queue, ref numBytesRead);

        }
        public void Close_A()
        {
            var status = (ViStatus)rs232_A.Close();
        }
        public uint GetBuferSize_A()
        {
            uint numberOfBytesOnBuffer = 0;

            rs232_A.GetRxBytesAvailable(ref numberOfBytesOnBuffer);

            return numberOfBytesOnBuffer;
        }
        #endregion


        #region PORT B SETTINGS
        public string OpenEx_B()
        {
            try
            {
                var status = (ViStatus)rs232_B.OpenByIndex(1);
                string isConnect = status.ToString();
                if (isConnect.Equals("Success"))
                {
                    return "Success";
                }
                else
                {
                    return "Connection Error";
                }

            }
            catch (Exception e)
            {
                return e.ToString();
            }

        }
        public void SetDataCharacteristics_B(byte DataBits, byte StopBits, byte Parity)
        {
            rs232_B.SetDataCharacteristics(DataBits, StopBits, Parity);
        }

        public void SetBaudRate_B(uint BaudRate)
        {
            rs232_B.SetBaudRate(BaudRate);

        }

        public void SetTimeouts_B(uint ReadTimeout, uint WriteTimeout)
        {
            var status = (ViStatus)rs232_B.SetTimeouts(ReadTimeout, WriteTimeout);
        }
        public void Write_B(byte[] dataBuffer, int numBytesToWrite, ref uint numBytesWritten)
        {
            rs232_B.Write(dataBuffer, numBytesToWrite, ref numBytesWritten);
        }
        public void Read_B(out string data, ref uint numBytesRead)
        {
            uint queue = 0;
            rs232_B.GetRxBytesAvailable(ref queue);

            rs232_B.Read(out data, queue, ref numBytesRead);
        }
        public void Close_B()
        {
            var status = (ViStatus)rs232_B.Close();
        }

        public uint GetBuferSize_B()
        {
            uint numberOfBytesOnBuffer = 0;

            rs232_B.GetRxBytesAvailable(ref numberOfBytesOnBuffer);

            return numberOfBytesOnBuffer;
        }

        #endregion

    }
}