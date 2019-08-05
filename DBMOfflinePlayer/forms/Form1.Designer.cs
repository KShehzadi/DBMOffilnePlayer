namespace DBMOfflinePlayer
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_about = new System.Windows.Forms.Button();
            this.btn_contactus = new System.Windows.Forms.Button();
            this.btn_dashboard = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(339, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "Enter ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_about);
            this.panel1.Controls.Add(this.btn_contactus);
            this.panel1.Controls.Add(this.btn_dashboard);
            this.panel1.Location = new System.Drawing.Point(-1, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 401);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Snow;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.btn_Exit);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.button1);
            this.panel2.ForeColor = System.Drawing.Color.Snow;
            this.panel2.Location = new System.Drawing.Point(199, -3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(831, 401);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Yellow;
            this.panel3.Location = new System.Drawing.Point(-10, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(841, 10);
            this.panel3.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Yellow;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Location = new System.Drawing.Point(18, 9);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(101, 100);
            this.panel4.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(64, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dashboard";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(64, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Contact us";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(78, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "About";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Image = global::DBMOfflinePlayer.Properties.Resources.DBM_Logo_Black_;
            this.pictureBox2.Location = new System.Drawing.Point(3, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(95, 67);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.ForeColor = System.Drawing.Color.White;
            this.btn_Exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_Exit.Image")));
            this.btn_Exit.Location = new System.Drawing.Point(756, 11);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(67, 43);
            this.btn_Exit.TabIndex = 5;
            this.btn_Exit.UseVisualStyleBackColor = false;
            // 
            // btn_about
            // 
            this.btn_about.BackColor = System.Drawing.Color.Transparent;
            this.btn_about.BackgroundImage = global::DBMOfflinePlayer.Properties.Resources.information_icon_white_4;
            this.btn_about.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_about.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_about.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_about.Location = new System.Drawing.Point(57, 279);
            this.btn_about.Name = "btn_about";
            this.btn_about.Size = new System.Drawing.Size(76, 53);
            this.btn_about.TabIndex = 2;
            this.btn_about.UseVisualStyleBackColor = false;
            // 
            // btn_contactus
            // 
            this.btn_contactus.BackColor = System.Drawing.Color.Transparent;
            this.btn_contactus.BackgroundImage = global::DBMOfflinePlayer.Properties.Resources.icon_call_center;
            this.btn_contactus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_contactus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_contactus.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_contactus.Location = new System.Drawing.Point(57, 177);
            this.btn_contactus.Name = "btn_contactus";
            this.btn_contactus.Size = new System.Drawing.Size(76, 63);
            this.btn_contactus.TabIndex = 2;
            this.btn_contactus.UseVisualStyleBackColor = false;
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.BackColor = System.Drawing.Color.Transparent;
            this.btn_dashboard.BackgroundImage = global::DBMOfflinePlayer.Properties.Resources.house_1_featured_2;
            this.btn_dashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_dashboard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_dashboard.Location = new System.Drawing.Point(57, 87);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Size = new System.Drawing.Size(76, 56);
            this.btn_dashboard.TabIndex = 0;
            this.btn_dashboard.Text = "\r\n";
            this.btn_dashboard.UseVisualStyleBackColor = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1024, 397);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1024, 397);
            this.MinimumSize = new System.Drawing.Size(1024, 397);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_dashboard;
        private System.Windows.Forms.Button btn_about;
        private System.Windows.Forms.Button btn_contactus;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

