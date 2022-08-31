using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace cpx400.DEVICES
{

    public class CPX400
    {

        string resourceName = "TCPIP::192.168.1.100::9221::SOCKET";
        int instrumentHandle = 0;
        double measurement = 0;

        public enum ViStatus
        {
            Success,
            Warnings,
            Errors,
            Null
        }
        public enum Channel
        {
            Ch1 = 1,
            Ch2 = 2,

        }

        Channel asd;


        public Channel NewEnum
        {
            get
            {
                return asd;
                ;
            }
            set
            {
                asd = value;
            }
        }

        //ctor
        public CPX400(string resourceName)
        {
            this.resourceName = resourceName;
        }

        public CPX400()
        {

        }

        #region DLL Imports
        [DllImport(@"C:\Users\stajyer6\Desktop\cpx400_project_GUI\cpx400\CPX400DP_32.dll", EntryPoint = "CPX400_init")]
        public static extern int CPX400_init(string resourceName, bool IDQuery, bool resetDevice, ref int instrumentHandle);

        [DllImport(@"C:\Users\stajyer6\Desktop\cpx400_project_GUI\cpx400\CPX400DP_32.dll", EntryPoint = "CPX400_ConfigureOutputEnabled")]
        public static extern int CPX400_ConfigureOutputEnabled(int instrumentHandle, string chName, bool enable);

        [DllImport(@"C:\Users\stajyer6\Desktop\cpx400_project_GUI\cpx400\CPX400DP_32.dll", EntryPoint = "CPX400_Measure")]
        public static extern int CPX400_Measure(int instrumentHandle, string chName, int measurementType, ref double measurement);

        [DllImport(@"C:\Users\stajyer6\Desktop\cpx400_project_GUI\cpx400\CPX400DP_32.dll", EntryPoint = "CPX400_ConfigureCurrentLimit")]
        public static extern int CPX400_ConfigureCurrentLimit(int instrumentHandle, string chName, long behavior, double limit);

        [DllImport(@"C:\Users\stajyer6\Desktop\cpx400_project_GUI\cpx400\CPX400DP_32.dll", EntryPoint = "CPX400_ConfigureOVP")]
        public static extern int CPX400_ConfigureOVP(int instrumentHandle, string chName, bool enabled, double limit);

        [DllImport(@"C:\Users\stajyer6\Desktop\cpx400_project_GUI\cpx400\CPX400DP_32.dll", EntryPoint = "CPX400_ConfigureVoltageLevel")]
        public static extern int CPX400_ConfigureVoltageLevel(int instrumentHandle, string chName, double level);

        [DllImport(@"C:\Users\stajyer6\Desktop\cpx400_project_GUI\cpx400\CPX400DP_32.dll", EntryPoint = "CPX400_ConfigureOCP")]
        public static extern int CPX400_ConfigureOCP(int instrumentHandle, string chName, double limit);

        [DllImport(@"C:\Users\stajyer6\Desktop\cpx400_project_GUI\cpx400\CPX400DP_32.dll", EntryPoint = "CPX400_close")]
        public static extern int CPX400_close(int instrumentHandle);

        [DllImport(@"C:\Users\stajyer6\Desktop\cpx400_project_GUI\cpx400\CPX400DP_32.dll", EntryPoint = "CPX400_reset")]
        public static extern int CPX400_reset(int instrumentHandle);

        [DllImport(@"C:\Users\stajyer6\Desktop\cpx400_project_GUI\cpx400\CPX400DP_32.dll", EntryPoint = "CPX400_ResetOutputProtection")]
        public static extern int CPX400_ResetOutputProtection(int instrumentHandle, string chnName);
        #endregion



        public string Initialize()
        {
            try
            {
                var status = (ViStatus)CPX400_init(resourceName, true, false, ref instrumentHandle);

                string isConnect = status.ToString();
                if (status == 0)
                {
                    return "Success";
                }
                else
                {
                    return "Failed to Connect (code : " + isConnect + " )";
                }
            }
            catch (Exception exception)
            {
                return exception.ToString();
            }
        }

        public void ConfigureOutputEnabled(string chName, bool isEnabled)
        {
            CPX400_ConfigureOutputEnabled(instrumentHandle, chName, isEnabled);
        }

        public double Measure(string chname, int measurementType, ref double measurement)
        {

            var asd = CPX400_Measure(instrumentHandle, chname, measurementType, ref measurement);

            return measurement;
        }
        public void ConfigureCurrentLimit(string chName, long behavior, double limit)
        {
            try
            {
                CPX400_ConfigureCurrentLimit(instrumentHandle, chName, behavior, limit);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void ConfigureOVP(string chName, bool enabled, double limit)
        {
            try
            {
                CPX400_ConfigureOVP(instrumentHandle, chName, enabled, limit);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);

            }
        }
        public void ConfigureVoltageLevel(string chname, double level)
        {

            try
            {
                var status = CPX400_ConfigureVoltageLevel(instrumentHandle, chname, level);

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void CPX400_ConfigureOCP(string chName, double limit)
        {
            try
            {
                var status = CPX400_ConfigureOCP(instrumentHandle, chName, limit);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public void Close()
        {

            Thread.Sleep(100);

            var status = (ViStatus)CPX400_close(instrumentHandle);
        }

        public void Reset()
        {
            CPX400_reset(instrumentHandle);
        }

        public void ResetOutputProtection(string chName)
        {
            try
            {
                CPX400_ResetOutputProtection(instrumentHandle, chName);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
