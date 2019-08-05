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
            this.tb_path = new System.Windows.Forms.TextBox();
            this.btn_browse = new System.Windows.Forms.Button();
            this.btn_play = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.imageBoxplayer = new Emgu.CV.UI.ImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxplayer)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Path of Folder Containning audio.mp3 and video.json";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tb_path
            // 
            this.tb_path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_path.Location = new System.Drawing.Point(30, 83);
            this.tb_path.Multiline = true;
            this.tb_path.Name = "tb_path";
            this.tb_path.ReadOnly = true;
            this.tb_path.Size = new System.Drawing.Size(724, 37);
            this.tb_path.TabIndex = 7;
            // 
            // btn_browse
            // 
            this.btn_browse.Location = new System.Drawing.Point(806, 83);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(98, 37);
            this.btn_browse.TabIndex = 8;
            this.btn_browse.Text = "Browse";
            this.btn_browse.UseVisualStyleBackColor = true;
            // 
            // btn_play
            // 
            this.btn_play.Location = new System.Drawing.Point(420, 442);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(143, 37);
            this.btn_play.TabIndex = 9;
            this.btn_play.Text = "Play";
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.White;
            this.btn_back.BackgroundImage = global::DBMOfflinePlayer.Properties.Resources._84942149_stock_vector_go_back_icon;
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.Location = new System.Drawing.Point(1, 2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(78, 57);
            this.btn_back.TabIndex = 11;
            this.btn_back.UseVisualStyleBackColor = false;
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.White;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.ForeColor = System.Drawing.Color.White;
            this.btn_Exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_Exit.Image")));
            this.btn_Exit.Location = new System.Drawing.Point(902, 2);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(67, 43);
            this.btn_Exit.TabIndex = 10;
            this.btn_Exit.UseVisualStyleBackColor = false;
            // 
            // imageBoxplayer
            // 
            this.imageBoxplayer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.imageBoxplayer.Location = new System.Drawing.Point(25, 133);
            this.imageBoxplayer.Name = "imageBoxplayer";
            this.imageBoxplayer.Size = new System.Drawing.Size(919, 293);
            this.imageBoxplayer.TabIndex = 5;
            this.imageBoxplayer.TabStop = false;
            // 
            // offlineplayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(970, 497);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.btn_browse);
            this.Controls.Add(this.tb_path);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imageBoxplayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "offlineplayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "offlineplayer";
            this.Load += new System.EventHandler(this.offlineplayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxplayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox imageBoxplayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_path;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_back;
    }
}