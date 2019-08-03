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
            this.imageBoxplayer = new Emgu.CV.UI.ImageBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_path = new System.Windows.Forms.TextBox();
            this.btn_browse = new System.Windows.Forms.Button();
            this.btn_play = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxplayer)).BeginInit();
            this.SuspendLayout();
            // 
            // imageBoxplayer
            // 
            this.imageBoxplayer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.imageBoxplayer.Location = new System.Drawing.Point(25, 73);
            this.imageBoxplayer.Name = "imageBoxplayer";
            this.imageBoxplayer.Size = new System.Drawing.Size(919, 293);
            this.imageBoxplayer.TabIndex = 5;
            this.imageBoxplayer.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Path of Folder Containning audio.mp3 and video.json";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tb_path
            // 
            this.tb_path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_path.Location = new System.Drawing.Point(25, 30);
            this.tb_path.Multiline = true;
            this.tb_path.Name = "tb_path";
            this.tb_path.ReadOnly = true;
            this.tb_path.Size = new System.Drawing.Size(724, 37);
            this.tb_path.TabIndex = 7;
            // 
            // btn_browse
            // 
            this.btn_browse.Location = new System.Drawing.Point(801, 30);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(98, 37);
            this.btn_browse.TabIndex = 8;
            this.btn_browse.Text = "Browse";
            this.btn_browse.UseVisualStyleBackColor = true;
            // 
            // btn_play
            // 
            this.btn_play.Location = new System.Drawing.Point(420, 384);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(143, 37);
            this.btn_play.TabIndex = 9;
            this.btn_play.Text = "Play";
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // offlineplayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 433);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.btn_browse);
            this.Controls.Add(this.tb_path);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imageBoxplayer);
            this.Name = "offlineplayer";
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
    }
}