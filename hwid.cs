using System;
using System.Collections.Generic;

using Microsoft.Win32;

namespace HWIDGrabber

{
    class HWDI

    {
        public static string GetMachineGuid()

        {
            string location = @"SOFTWARE\Microsoft\Cryptography";
            string name = "MachineGuid";
    

            //Navigates in ur registry
            using (RegistryKey localMachineX64View = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
    
            {
                using (RegistryKey rk = localMachineX64View.OpenSubKey(location))
        
                {
                    if (rk == null)
                
                        throw new KeyNotFoundException(string.Format("Key Not Found: {0}", location));

                    object machineGuid = rk.GetValue(name);
            
                    if (machineGuid == null)
                        throw new IndexOutOfRangeException(string.Format("Index Not Found: {0}", name));
            

                    return machineGuid.ToString();
                }
        
            }
        }

    }
}

