/*
 * NSLoader
 * Made By : Daxor
 * Credits :
 * Wilson : Used his SimpleLoader as a base
 * Roshly : Pasted his HWID.cs and check.php
 * AeonHack for the NetSeal theme
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NSLoader
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
