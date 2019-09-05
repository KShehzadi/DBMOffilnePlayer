namespace DBMOfflinePlayer.forms
{
    partial class offlineplayer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(offlineplayer));
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTotalTime = new System.Windows.Forms.Label();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_startover = new System.Windows.Forms.Button();
            this.btn_pause = new System.Windows.Forms.Button();
            this.btn_play = new System.Windows.Forms.Button();
            this.imageBoxplayer = new Emgu.CV.UI.ImageBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxplayer)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(449, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name of Lecture";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.btn_back);
            this.panel3.Controls.Add(this.btn_Exit);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1024, 30);
            this.panel3.TabIndex = 12;
            // 
            // lblTotalTime
            // 
            this.lblTotalTime.AutoSize = true;
            this.lblTotalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotalTime.Location = new System.Drawing.Point(965, 373);
            this.lblTotalTime.Name = "lblTotalTime";
            this.lblTotalTime.Size = new System.Drawing.Size(46, 17);
            this.lblTotalTime.TabIndex = 13;
            this.lblTotalTime.Text = "--:--:--";
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.AutoSize = true;
            this.lblCurrentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCurrentTime.Location = new System.Drawing.Point(22, 374);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(46, 17);
            this.lblCurrentTime.TabIndex = 14;
            this.lblCurrentTime.Text = "--:--:--";
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.Gray;
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(66, 370);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(877, 45);
            this.trackBar1.TabIndex = 16;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_back.BackgroundImage = global::DBMOfflinePlayer.Properties.Resources.Industry_Return_icon1;
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_back.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_back.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_back.FlatAppearance.BorderSize = 5;
            this.btn_back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_back.ForeColor = System.Drawing.Color.Transparent;
            this.btn_back.Location = new System.Drawing.Point(0, 0);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(47, 30);
            this.btn_back.TabIndex = 11;
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_Exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.ForeColor = System.Drawing.Color.White;
            this.btn_Exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_Exit.Image")));
            this.btn_Exit.Location = new System.Drawing.Point(976, 0);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(48, 30);
            this.btn_Exit.TabIndex = 10;
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_startover
            // 
            this.btn_startover.BackColor = System.Drawing.Color.Transparent;
            this.btn_startover.BackgroundImage = global::DBMOfflinePlayer.Properties.Resources.startovericon;
            this.btn_startover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_startover.FlatAppearance.BorderSize = 0;
            this.btn_startover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_startover.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_startover.Location = new System.Drawing.Point(391, 448);
            this.btn_startover.Name = "btn_startover";
            this.btn_startover.Size = new System.Drawing.Size(70, 50);
            this.btn_startover.TabIndex = 9;
            this.btn_startover.UseVisualStyleBackColor = false;
            this.btn_startover.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_pause
            // 
            this.btn_pause.BackColor = System.Drawing.Color.Transparent;
            this.btn_pause.BackgroundImage = global::DBMOfflinePlayer.Properties.Resources.pause;
            this.btn_pause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_pause.FlatAppearance.BorderSize = 0;
            this.btn_pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pause.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pause.Location = new System.Drawing.Point(631, 449);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(64, 46);
            this.btn_pause.TabIndex = 9;
            this.btn_pause.UseVisualStyleBackColor = false;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // btn_play
            // 
            this.btn_play.BackColor = System.Drawing.Color.Transparent;
            this.btn_play.BackgroundImage = global::DBMOfflinePlayer.Properties.Resources.a6508e565d25ab01f79a35c4319e0083_play_button_flat_icon_by_vexels;
            this.btn_play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_play.FlatAppearance.BorderSize = 0;
            this.btn_play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_play.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_play.Location = new System.Drawing.Point(497, 439);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(100, 74);
            this.btn_play.TabIndex = 9;
            this.btn_play.UseVisualStyleBackColor = false;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // imageBoxplayer
            // 
            this.imageBoxplayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.imageBoxplayer.Location = new System.Drawing.Point(0, -1);
            this.imageBoxplayer.Name = "imageBoxplayer";
            this.imageBoxplayer.Size = new System.Drawing.Size(1024, 370);
            this.imageBoxplayer.TabIndex = 5;
            this.imageBoxplayer.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.imageBoxplayer);
            this.panel1.Controls.Add(this.lblTotalTime);
            this.panel1.Controls.Add(this.lblCurrentTime);
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 408);
            this.panel1.TabIndex = 17;
            // 
            // offlineplayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1024, 520);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btn_startover);
            this.Controls.Add(this.btn_pause);
            this.Controls.Add(this.btn_play);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1024, 520);
            this.MinimumSize = new System.Drawing.Size(1024, 520);
            this.Name = "offlineplayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "offlineplayer";
            this.Load += new System.EventHandler(this.offlineplayer_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxplayer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Emgu.CV.UI.ImageBox imageBoxplayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_pause;
        private System.Windows.Forms.Label lblTotalTime;
        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button btn_startover;
        private System.Windows.Forms.Panel panel1;
    }
}