namespace NSLoader
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nsTheme1 = new PokemonGoBot.GUI.GUI.Theme.NSTheme();
            this.nsControlButton2 = new PokemonGoBot.GUI.GUI.Theme.NSControlButton();
            this.nsControlButton1 = new PokemonGoBot.GUI.GUI.Theme.NSControlButton();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nsButton1 = new PokemonGoBot.GUI.GUI.Theme.NSButton();
            this.nsTextBox2 = new PokemonGoBot.GUI.GUI.Theme.NSTextBox();
            this.nsTextBox1 = new PokemonGoBot.GUI.GUI.Theme.NSTextBox();
            this.nsTheme1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nsTheme1
            // 
            this.nsTheme1.AccentOffset = 0;
            this.nsTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.nsTheme1.Colors = new PokemonGoBot.GUI.GUI.Theme.Bloom[0];
            this.nsTheme1.Controls.Add(this.nsControlButton2);
            this.nsTheme1.Controls.Add(this.nsControlButton1);
            this.nsTheme1.Controls.Add(this.linkLabel1);
            this.nsTheme1.Controls.Add(this.label2);
            this.nsTheme1.Controls.Add(this.label1);
            this.nsTheme1.Controls.Add(this.nsButton1);
            this.nsTheme1.Controls.Add(this.nsTextBox2);
            this.nsTheme1.Controls.Add(this.nsTextBox1);
            this.nsTheme1.Customization = "";
            this.nsTheme1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nsTheme1.Font = new System.Drawing.Font("Verdana", 8F);
            this.nsTheme1.Image = null;
            this.nsTheme1.Location = new System.Drawing.Point(0, 0);
            this.nsTheme1.Movable = true;
            this.nsTheme1.Name = "nsTheme1";
            this.nsTheme1.NoRounding = false;
            this.nsTheme1.Sizable = false;
            this.nsTheme1.Size = new System.Drawing.Size(332, 164);
            this.nsTheme1.SmartBounds = true;
            this.nsTheme1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.nsTheme1.TabIndex = 0;
            this.nsTheme1.Text = "Login";
            this.nsTheme1.TransparencyKey = System.Drawing.Color.Empty;
            this.nsTheme1.Transparent = false;
            this.nsTheme1.Click += new System.EventHandler(this.nsTheme1_Click);
            // 
            // nsControlButton2
            // 
            this.nsControlButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nsControlButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.nsControlButton2.ControlButton = PokemonGoBot.GUI.GUI.Theme.NSControlButton.Button.Minimize;
            this.nsControlButton2.Location = new System.Drawing.Point(291, 2);
            this.nsControlButton2.Margin = new System.Windows.Forms.Padding(0);
            this.nsControlButton2.MaximumSize = new System.Drawing.Size(18, 20);
            this.nsControlButton2.MinimumSize = new System.Drawing.Size(18, 20);
            this.nsControlButton2.Name = "nsControlButton2";
            this.nsControlButton2.Size = new System.Drawing.Size(18, 20);
            this.nsControlButton2.TabIndex = 7;
            this.nsControlButton2.Text = "nsControlButton2";
            // 
            // nsControlButton1
            // 
            this.nsControlButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nsControlButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.nsControlButton1.ControlButton = PokemonGoBot.GUI.GUI.Theme.NSControlButton.Button.Close;
            this.nsControlButton1.Location = new System.Drawing.Point(309, 2);
            this.nsControlButton1.Margin = new System.Windows.Forms.Padding(0);
            this.nsControlButton1.MaximumSize = new System.Drawing.Size(18, 20);
            this.nsControlButton1.MinimumSize = new System.Drawing.Size(18, 20);
            this.nsControlButton1.Name = "nsControlButton1";
            this.nsControlButton1.Size = new System.Drawing.Size(18, 20);
            this.nsControlButton1.TabIndex = 6;
            this.nsControlButton1.Text = "nsControlButton1";
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.SystemColors.Control;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.LinkColor = System.Drawing.SystemColors.Control;
            this.linkLabel1.Location = new System.Drawing.Point(226, 148);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(107, 13);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Forgot Password?";
            this.linkLabel1.VisitedLinkColor = System.Drawing.SystemColors.Control;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(122, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(118, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username";
            // 
            // nsButton1
            // 
            this.nsButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.nsButton1.Location = new System.Drawing.Point(127, 127);
            this.nsButton1.Name = "nsButton1";
            this.nsButton1.Size = new System.Drawing.Size(75, 23);
            this.nsButton1.TabIndex = 2;
            this.nsButton1.Text = "Login";
            this.nsButton1.Click += new System.EventHandler(this.nsButton1_Click);
            // 
            // nsTextBox2
            // 
            this.nsTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.nsTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nsTextBox2.Location = new System.Drawing.Point(76, 100);
            this.nsTextBox2.MaxLength = 32767;
            this.nsTextBox2.Multiline = false;
            this.nsTextBox2.Name = "nsTextBox2";
            this.nsTextBox2.ReadOnly = false;
            this.nsTextBox2.Size = new System.Drawing.Size(165, 23);
            this.nsTextBox2.TabIndex = 1;
            this.nsTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.nsTextBox2.UseSystemPasswordChar = false;
            this.nsTextBox2.TextChanged += new System.EventHandler(this.nsTextBox2_TextChanged);
            // 
            // nsTextBox1
            // 
            this.nsTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.nsTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nsTextBox1.Location = new System.Drawing.Point(76, 58);
            this.nsTextBox1.MaxLength = 32767;
            this.nsTextBox1.Multiline = false;
            this.nsTextBox1.Name = "nsTextBox1";
            this.nsTextBox1.ReadOnly = false;
            this.nsTextBox1.Size = new System.Drawing.Size(165, 23);
            this.nsTextBox1.TabIndex = 0;
            this.nsTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.nsTextBox1.UseSystemPasswordChar = false;
            this.nsTextBox1.TextChanged += new System.EventHandler(this.nsTextBox1_TextChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 164);
            this.ControlBox = false;
            this.Controls.Add(this.nsTheme1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            this.nsTheme1.ResumeLayout(false);
            this.nsTheme1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PokemonGoBot.GUI.GUI.Theme.NSTheme nsTheme1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private PokemonGoBot.GUI.GUI.Theme.NSButton nsButton1;
        private PokemonGoBot.GUI.GUI.Theme.NSTextBox nsTextBox2;
        private PokemonGoBot.GUI.GUI.Theme.NSTextBox nsTextBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private PokemonGoBot.GUI.GUI.Theme.NSControlButton nsControlButton2;
        private PokemonGoBot.GUI.GUI.Theme.NSControlButton nsControlButton1;
    }
}