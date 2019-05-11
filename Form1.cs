using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;

namespace NSLoader

{
public partial class Form1 : Form
{
    [DllImport("InjectLib.dll", CallingConvention = CallingConvention.Cdecl)]
    private extern static void Inject(byte[] buf);

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

        label1.Text = "Welcome, " + Login.theusername + ".";

        WebClient changelog = new WebClient();
        string change = changelog.DownloadString(Settings.changelog);

        textBox1.Text = change;



    }

    private void nsButton1_Click(object sender, EventArgs e)
    {
        this.Hide(); // hides the loader, comment it out if you dont want it to hide
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
        wb.Headers.Add("User-Agent", Settings.useragent); // adds useragent for leak protection
        var target = Process.GetProcessesByName("csgo").FirstOrDefault(); // we get the PID for csgo
        byte[] file = wb.DownloadData(dllr); // we download the dll to a byte array, much more secure than saving to the disk unlike most loaders

        while (Process.GetProcessesByName("csgo").Length == 0) //if csgo isnt started
        {
            Thread.Sleep(500); //sleeps for .5 seconds
        }

        //this is to check if main menu is loaded for auto injection
        //credits to https://www.unknowncheats.me/forum/1593535-post4.html

        bool Clientdll_Found = false; //initialize client_found with false
        bool Enginedll_Found = false;//initialize engine_found with false


        do
        {
            Process[] CheckModules = Process.GetProcessesByName("csgo");

            foreach (ProcessModule m in CheckModules[0].Modules)
            {
                if (m.ModuleName == "client_panorama.dll") //this is to check if client_panorama.dll is loaded
                {
                    Clientdll_Found = true;
                }
            }

        } while (Clientdll_Found == false); //loop while not loaded



        do
        {
            Process[] CheckModules = Process.GetProcessesByName("csgo");

            foreach (ProcessModule m in CheckModules[0].Modules)
            {
                if (m.ModuleName == "engine.dll") //this is to check if engine.dll is loaded
                {
                    Enginedll_Found = true;
                }
            }

        } while (Enginedll_Found == false); //loop while not loaded


        if (Clientdll_Found == true && Enginedll_Found == true) //if its loaded
        {
            Thread.Sleep(2000); //sleep for 2 seconds
            Inject(file); //inject the dll
            Application.Exit(); //close the loader, commment out if you dont want it to close
        }



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



