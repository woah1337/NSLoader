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
using UHWID;

namespace NSLoader {
	public partial class Login: Form {
		string hwid; // declares hwid so we can assign a value to it later
		public static string theusername;
		public Login() {
			InitializeComponent();
			hwid = UHWIDEngine.AdvancedUid; // gets hwid and assigns it to the string hwid

		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			System.Diagnostics.Process.Start(Settings.forgotpassword); // opens forgot password website
		}

		private void nsButton1_Click(object sender, EventArgs e) {
			theusername = nsTextBox1.Text;
			WebClient wb = new WebClient(); // creats a new webclient called wb
			string loginstring; // declares a string called loginstring so we can assign a value later
			wb.Headers.Add("User-Agent", Settings.useragent); // adds useragent for leak protection
			loginstring = wb.DownloadString(Settings.check + "?username=" + nsTextBox1.Text + "&password=" + nsTextBox2.Text + "&hwid=" + hwid); // makes a webrequest using wb for authentication, other parameters are in Settings.cs
			//loginstring = "p1g4h1"; // for testing, do NOT uncomment unless you want authentication to be disabled.
			if (loginstring.Contains("p1")) //if the password is correct
			{
				if (loginstring.Contains("g4") || loginstring.Contains("g6") || loginstring.Contains("g8")) //if the group is either 4, 6 or 8

				{
					if (loginstring.Contains("h1")) //if the hwid is correct
					{
						var form1 = new Form1(); //variable for new form
						form1.Closed += (s, args) = >this.Close();
						MessageBox.Show("Logged in!"); // messagebox that says logged in
						form1.Show(); //show new form
						this.Hide(); //hide current form
					}
					else if (loginstring.Contains("h2")) // if the hwid is wrong

					{
						MessageBox.Show("Incorrect HWID", "ERROR"); //show messagebox that says wrong hwid
					}
					else if (loginstring.Contains("h3")) //if the hwid is blank
					{
						MessageBox.Show("Setting new HWID", "HWID Reset"); //messagebox that says hwid reset
					}

				}
				else //if the group is wrong

				{
					MessageBox.Show("You are not VIP", "ERROR"); //messagebox that says you are not vip
				}

			}
			else // if the password is wrong

			{
				MessageBox.Show("Incorrect username or password", "ERROR"); //messagebox that says password is wrong
			}

		}

		private void nsTextBox1_TextChanged(object sender, EventArgs e) {

}

		private void nsTheme1_Click(object sender, EventArgs e) {

}

		private void nsTextBox2_TextChanged(object sender, EventArgs e) {

}

	}
}