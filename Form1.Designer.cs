namespace TFMusic_New
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.lblMusica = new System.Windows.Forms.Label();
            this.lblTempo = new System.Windows.Forms.Label();
            this.lblVolume = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btTras = new System.Windows.Forms.Button();
            this.btFrente = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btPlay = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btOff = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btMudo = new System.Windows.Forms.Button();
            this.lblVersao = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(16)))));
            this.trackBar1.Cursor = System.Windows.Forms.Cursors.Default;
            this.trackBar1.Location = new System.Drawing.Point(406, 230);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(87, 24);
            this.trackBar1.TabIndex = 5;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.AutoSize = false;
            this.trackBar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(13)))));
            this.trackBar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar2.LargeChange = 15;
            this.trackBar2.Location = new System.Drawing.Point(17, 60);
            this.trackBar2.Maximum = 10000;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(393, 27);
            this.trackBar2.TabIndex = 10;
            this.trackBar2.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // lblMusica
            // 
            this.lblMusica.BackColor = System.Drawing.Color.Transparent;
            this.lblMusica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMusica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(0)))));
            this.lblMusica.Location = new System.Drawing.Point(23, 23);
            this.lblMusica.Name = "lblMusica";
            this.lblMusica.Size = new System.Drawing.Size(461, 23);
            this.lblMusica.TabIndex = 11;
            // 
            // lblTempo
            // 
            this.lblTempo.BackColor = System.Drawing.Color.Transparent;
            this.lblTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(0)))));
            this.lblTempo.Location = new System.Drawing.Point(421, 59);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(83, 29);
            this.lblTempo.TabIndex = 12;
            // 
            // lblVolume
            // 
            this.lblVolume.BackColor = System.Drawing.Color.Transparent;
            this.lblVolume.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(0)))));
            this.lblVolume.Location = new System.Drawing.Point(490, 234);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(27, 12);
            this.lblVolume.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::TFMusic_New.Properties.Resources.btnMin;
            this.button1.Location = new System.Drawing.Point(286, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 48);
            this.button1.TabIndex = 16;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btTras
            // 
            this.btTras.BackColor = System.Drawing.Color.Transparent;
            this.btTras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btTras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btTras.FlatAppearance.BorderSize = 0;
            this.btTras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btTras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btTras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTras.Image = global::TFMusic_New.Properties.Resources.btnVoltar;
            this.btTras.Location = new System.Drawing.Point(28, 30);
            this.btTras.Name = "btTras";
            this.btTras.Size = new System.Drawing.Size(51, 37);
            this.btTras.TabIndex = 1;
            this.btTras.UseVisualStyleBackColor = false;
            this.btTras.Click += new System.EventHandler(this.btTras_Click);
            // 
            // btFrente
            // 
            this.btFrente.BackColor = System.Drawing.Color.Transparent;
            this.btFrente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btFrente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btFrente.FlatAppearance.BorderSize = 0;
            this.btFrente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btFrente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btFrente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFrente.Image = global::TFMusic_New.Properties.Resources.btnAvancar;
            this.btFrente.Location = new System.Drawing.Point(316, 30);
            this.btFrente.Name = "btFrente";
            this.btFrente.Size = new System.Drawing.Size(52, 36);
            this.btFrente.TabIndex = 18;
            this.btFrente.UseMnemonic = false;
            this.btFrente.UseVisualStyleBackColor = true;
            this.btFrente.Click += new System.EventHandler(this.btFrente_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Image = global::TFMusic_New.Properties.Resources.logo4;
            this.pictureBox3.Location = new System.Drawing.Point(-5, 9);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(232, 45);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::TFMusic_New.Properties.Resources.btnPause;
            this.button3.Location = new System.Drawing.Point(176, 30);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(46, 36);
            this.button3.TabIndex = 20;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // btPlay
            // 
            this.btPlay.BackColor = System.Drawing.Color.Transparent;
            this.btPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btPlay.FlatAppearance.BorderSize = 0;
            this.btPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPlay.Image = global::TFMusic_New.Properties.Resources.btnPlay;
            this.btPlay.Location = new System.Drawing.Point(103, 31);
            this.btPlay.Name = "btPlay";
            this.btPlay.Size = new System.Drawing.Size(48, 36);
            this.btPlay.TabIndex = 21;
            this.btPlay.UseVisualStyleBackColor = false;
            this.btPlay.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Image = global::TFMusic_New.Properties.Resources.btnStop;
            this.button5.Location = new System.Drawing.Point(256, 29);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(38, 38);
            this.button5.TabIndex = 22;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btOff
            // 
            this.btOff.BackColor = System.Drawing.Color.Transparent;
            this.btOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btOff.FlatAppearance.BorderSize = 0;
            this.btOff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btOff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOff.Image = global::TFMusic_New.Properties.Resources.btnOFF;
            this.btOff.Location = new System.Drawing.Point(404, 11);
            this.btOff.Name = "btOff";
            this.btOff.Size = new System.Drawing.Size(116, 45);
            this.btOff.TabIndex = 23;
            this.btOff.UseVisualStyleBackColor = false;
            this.btOff.Click += new System.EventHandler(this.btOff_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::TFMusic_New.Properties.Resources.bgPlayers;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.btTras);
            this.panel1.Controls.Add(this.btFrente);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btPlay);
            this.panel1.Location = new System.Drawing.Point(0, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 101);
            this.panel1.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::TFMusic_New.Properties.Resources.bgMusic;
            this.panel2.Controls.Add(this.lblMusica);
            this.panel2.Controls.Add(this.trackBar2);
            this.panel2.Controls.Add(this.lblTempo);
            this.panel2.Location = new System.Drawing.Point(2, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(530, 100);
            this.panel2.TabIndex = 27;
            // 
            // btMudo
            // 
            this.btMudo.BackColor = System.Drawing.Color.Transparent;
            this.btMudo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btMudo.FlatAppearance.BorderSize = 0;
            this.btMudo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btMudo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btMudo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMudo.Image = global::TFMusic_New.Properties.Resources.MuteOn;
            this.btMudo.Location = new System.Drawing.Point(415, 179);
            this.btMudo.Name = "btMudo";
            this.btMudo.Size = new System.Drawing.Size(75, 45);
            this.btMudo.TabIndex = 28;
            this.btMudo.UseVisualStyleBackColor = false;
            this.btMudo.Click += new System.EventHandler(this.btMudo_Click);
            // 
            // lblVersao
            // 
            this.lblVersao.BackColor = System.Drawing.Color.Transparent;
            this.lblVersao.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(0)))));
            this.lblVersao.Location = new System.Drawing.Point(467, 265);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(53, 13);
            this.lblVersao.TabIndex = 29;
            this.lblVersao.Text = "3.0.0";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 14);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(41, 53);
            this.axWindowsMediaPlayer1.TabIndex = 7;
            this.axWindowsMediaPlayer1.Visible = false;
            this.axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer1_PlayStateChange);
            this.axWindowsMediaPlayer1.PositionChange += new AxWMPLib._WMPOCXEvents_PositionChangeEventHandler(this.axWindowsMediaPlayer1_PositionChange);
            this.axWindowsMediaPlayer1.CurrentItemChange += new AxWMPLib._WMPOCXEvents_CurrentItemChangeEventHandler(this.axWindowsMediaPlayer1_CurrentItemChange);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(33)))), ((int)(((byte)(40)))));
            this.BackgroundImage = global::TFMusic_New.Properties.Resources.bg2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(522, 279);
            this.Controls.Add(this.lblVersao);
            this.Controls.Add(this.btMudo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btOff);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Track-Music";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing_1);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TrackBar trackBar1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label lblMusica;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btTras;
        private System.Windows.Forms.Button btFrente;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btPlay;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btOff;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btMudo;
        private System.Windows.Forms.Label lblVersao;
    }
}

