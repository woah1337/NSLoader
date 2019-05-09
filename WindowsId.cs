using System;
using System.Management;
using System.Security.Cryptography;
using System.Text;

namespace UHWID
{
    internal class WindowsId
    {
        public static string GetWindowsId()
        {
            var windowsInfo = "";
            var managClass = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_OperatingSystem");

            var managCollec = managClass.Get();

            var is64Bits = !string.IsNullOrEmpty(Environment.GetEnvironmentVariable("PROCESSOR_ARCHITEW6432"));

            foreach (var o in managCollec)
            {
                var managObj = (ManagementObject)o;
                windowsInfo = managObj.Properties["Caption"].Value + Environment.UserName + (string)managObj.Properties["Version"].Value;
                break;
            }
            windowsInfo = windowsInfo.Replace(" ", "");
            windowsInfo = windowsInfo.Replace("Windows", "");
            windowsInfo = windowsInfo.Replace("windows", "");
            windowsInfo += (is64Bits) ? " 64bit" : " 32bit";

            //md5 hash of the windows version
            var md5Hasher = MD5.Create();
            var wi = md5Hasher.ComputeHash(Encoding.Default.GetBytes(windowsInfo));
            var wiHex = BitConverter.ToString(wi).Replace("-", "");
            return wiHex;
        }
    }
}