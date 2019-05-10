namespace NSLoader
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.nsTheme1 = new PokemonGoBot.GUI.GUI.Theme.NSTheme();
            this.nsControlButton3 = new PokemonGoBot.GUI.GUI.Theme.NSControlButton();
            this.nsControlButton1 = new PokemonGoBot.GUI.GUI.Theme.NSControlButton();
            this.nsTabControl1 = new PokemonGoBot.GUI.GUI.Theme.NSTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.nsComboBox1 = new PokemonGoBot.GUI.GUI.Theme.NSComboBox();
            this.nsButton1 = new PokemonGoBot.GUI.GUI.Theme.NSButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nsTheme1.SuspendLayout();
            this.nsTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(475, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // nsTheme1
            // 
            this.nsTheme1.AccentOffset = 0;
            this.nsTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.nsTheme1.Colors = new PokemonGoBot.GUI.GUI.Theme.Bloom[0];
            this.nsTheme1.Controls.Add(this.nsControlButton3);
            this.nsTheme1.Controls.Add(this.nsControlButton1);
            this.nsTheme1.Controls.Add(this.nsTabControl1);
            this.nsTheme1.Customization = "";
            this.nsTheme1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nsTheme1.Font = new System.Drawing.Font("Verdana", 8F);
            this.nsTheme1.Image = null;
            this.nsTheme1.Location = new System.Drawing.Point(0, 0);
            this.nsTheme1.Margin = new System.Windows.Forms.Padding(2);
            this.nsTheme1.Movable = true;
            this.nsTheme1.Name = "nsTheme1";
            this.nsTheme1.NoRounding = false;
            this.nsTheme1.Sizable = false;
            this.nsTheme1.Size = new System.Drawing.Size(329, 154);
            this.nsTheme1.SmartBounds = true;
            this.nsTheme1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.nsTheme1.TabIndex = 5;
            this.nsTheme1.Text = "NSLoader";
            this.nsTheme1.TransparencyKey = System.Drawing.Color.Empty;
            this.nsTheme1.Transparent = false;
            this.nsTheme1.Click += new System.EventHandler(this.nsTheme1_Click);
            // 
            // nsControlButton3
            // 
            this.nsControlButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nsControlButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.nsControlButton3.ControlButton = PokemonGoBot.GUI.GUI.Theme.NSControlButton.Button.Minimize;
            this.nsControlButton3.Location = new System.Drawing.Point(285, 3);
            this.nsControlButton3.Margin = new System.Windows.Forms.Padding(0);
            this.nsControlButton3.MaximumSize = new System.Drawing.Size(18, 20);
            this.nsControlButton3.MinimumSize = new System.Drawing.Size(18, 20);
            this.nsControlButton3.Name = "nsControlButton3";
            this.nsControlButton3.Size = new System.Drawing.Size(18, 20);
            this.nsControlButton3.TabIndex = 8;
            this.nsControlButton3.Text = "nsControlButton3";
            // 
            // nsControlButton1
            // 
            this.nsControlButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nsControlButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.nsControlButton1.ControlButton = PokemonGoBot.GUI.GUI.Theme.NSControlButton.Button.Close;
            this.nsControlButton1.Location = new System.Drawing.Point(303, 3);
            this.nsControlButton1.Margin = new System.Windows.Forms.Padding(0);
            this.nsControlButton1.MaximumSize = new System.Drawing.Size(18, 20);
            this.nsControlButton1.MinimumSize = new System.Drawing.Size(18, 20);
            this.nsControlButton1.Name = "nsControlButton1";
            this.nsControlButton1.Size = new System.Drawing.Size(18, 20);
            this.nsControlButton1.TabIndex = 6;
            this.nsControlButton1.Text = "nsControlButton1";
            // 
            // nsTabControl1
            // 
            this.nsTabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.nsTabControl1.Controls.Add(this.tabPage1);
            this.nsTabControl1.Controls.Add(this.tabPage3);
            this.nsTabControl1.Controls.Add(this.tabPage2);
            this.nsTabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.nsTabControl1.ItemSize = new System.Drawing.Size(28, 115);
            this.nsTabControl1.Location = new System.Drawing.Point(0, 27);
            this.nsTabControl1.Multiline = true;
            this.nsTabControl1.Name = "nsTabControl1";
            this.nsTabControl1.SelectedIndex = 0;
            this.nsTabControl1.Size = new System.Drawing.Size(329, 127);
            this.nsTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.nsTabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.nsComboBox1);
            this.tabPage1.Controls.Add(this.nsButton1);
            this.tabPage1.Location = new System.Drawing.Point(119, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(206, 119);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dashboard";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Welcome, Daxor.";
            // 
            // nsComboBox1
            // 
            this.nsComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.nsComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.nsComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nsComboBox1.ForeColor = System.Drawing.Color.White;
            this.nsComboBox1.FormattingEnabled = true;
            this.nsComboBox1.Location = new System.Drawing.Point(36, 37);
            this.nsComboBox1.Name = "nsComboBox1";
            this.nsComboBox1.Size = new System.Drawing.Size(121, 21);
            this.nsComboBox1.TabIndex = 5;
            this.nsComboBox1.SelectedIndexChanged += new System.EventHandler(this.nsComboBox1_SelectedIndexChanged);
            // 
            // nsButton1
            // 
            this.nsButton1.Location = new System.Drawing.Point(64, 64);
            this.nsButton1.Name = "nsButton1";
            this.nsButton1.Size = new System.Drawing.Size(72, 26);
            this.nsButton1.TabIndex = 4;
            this.nsButton1.Text = "Inject";
            this.nsButton1.Click += new System.EventHandler(this.nsButton1_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Location = new System.Drawing.Point(119, 4);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(206, 119);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Changelog";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(2, 5);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(200, 110);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Changelog";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Location = new System.Drawing.Point(119, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(206, 119);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Support";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::NSLoader.Properties.Resources.img_131344;
            this.pictureBox2.Location = new System.Drawing.Point(112, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(91, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NSLoader.Properties.Resources.discord_512;
            this.pictureBox1.Location = new System.Drawing.Point(3, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 154);
            this.ControlBox = false;
            this.Controls.Add(this.nsTheme1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "NSLoader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.nsTheme1.ResumeLayout(false);
            this.nsTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private PokemonGoBot.GUI.GUI.Theme.NSButton nsButton1;
        private PokemonGoBot.GUI.GUI.Theme.NSTheme nsTheme1;
        private PokemonGoBot.GUI.GUI.Theme.NSTabControl nsTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private PokemonGoBot.GUI.GUI.Theme.NSComboBox nsComboBox1;
        private PokemonGoBot.GUI.GUI.Theme.NSControlButton nsControlButton3;
        private PokemonGoBot.GUI.GUI.Theme.NSControlButton nsControlButton1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}

