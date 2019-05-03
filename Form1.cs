using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManualMapInjection.Injection;
using System.Net;
using System.IO;
using System.Diagnostics;

namespace NSLoader

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            nsComboBox1.Items.Add(Settings.first); //add first item to netseal combobox 
            if (Settings.items >= 2) //if items are equal to or greater than 2
            nsComboBox1.Items.Add(Settings.second); //add second item in netseal combobox  
            if (Settings.items >= 3) //if items are equal to or greater than 3
            nsComboBox1.Items.Add(Settings.third); //add third item in netseal combobox    
            nsComboBox1.SelectedIndex = 0; //make the default value for the combobox the first item

        }

        private void nsButton1_Click(object sender, EventArgs e)
        {
            string dllr = "0"; //initialize dllr with a value of 0, we are going to use it for the dll link
            if (nsComboBox1.SelectedIndex == 0) //if the first item is selected
            {
                dllr = Settings.firstdll; //dllr is set to firstdll
            }
            else
            {
                if (nsComboBox1.SelectedIndex == 1) // if the second item is selected
                {
                    dllr = Settings.seconddll; //dllr is set to seconddll
                }
                else
                {
                    if (nsComboBox1.SelectedIndex == 2) // if the third item is selected
                    {
                        dllr = Settings.thirddll; // dllr is set to thirddll
                    }
                    else
                        MessageBox.Show("Couldn't Select Cheat", "Error"); // if there is an error, the user will get a messagebox that says couldnt select cheat
                }
            }
            WebClient wb = new WebClient(); // we create a new webclient
            wb.Headers.Add(Settings.useragent); // adds useragent for leak protection
            var target = Process.GetProcessesByName("csgo").FirstOrDefault(); // we get the PID for csgo
            byte[] file = wb.DownloadData(dllr); // we download the dll to a byte array, much more secure than saving to the disk unlike most loaders
          
            


            //Injection, just leave this alone if you are a beginner
            var injector = new ManualMapInjector(target) { AsyncInjection = true };
            label2.Text = $"hmodule = 0x{injector.Inject(file).ToInt64():x8}";

            MessageBox.Show("Injected"); // shows a messagebox saying injected
        }

        private void pictureBox1_Click(object sender, EventArgs e) //if picturebox1 is clicked
        {
            System.Diagnostics.Process.Start(Settings.discord); //opens the string discord with the default browser
        }

        private void pictureBox2_Click(object sender, EventArgs e) //if picturebox2 is clicked
        {
            System.Diagnostics.Process.Start(Settings.forum); //opens the string forum with the default browser
        }

        public void nsComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        private void nsTheme1_Click(object sender, EventArgs e)
        {

        }
    }
}

      
    
