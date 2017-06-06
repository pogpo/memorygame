﻿namespace Memory_Game
{
    partial class FrmMemory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMemory));
            this.mnuNormal = new System.Windows.Forms.MenuItem();
            this.mnuTime = new System.Windows.Forms.MenuItem();
            this.mnuStep = new System.Windows.Forms.MenuItem();
            this.mnuNewGame = new System.Windows.Forms.MenuItem();
            this.mnuReplay = new System.Windows.Forms.MenuItem();
            this.mnuExit = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.mnuSaveCurrent = new System.Windows.Forms.MenuItem();
            this.mnuLoadgame = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.mnuAbout = new System.Windows.Forms.MenuItem();
            this.mnuInstructions = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblYourtime = new System.Windows.Forms.Label();
            this.lblClicks = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTen = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.btnPause = new System.Windows.Forms.Button();
            this.lable3 = new System.Windows.Forms.Label();
            this.lable4 = new System.Windows.Forms.Label();
            this.lblYScore = new System.Windows.Forms.Label();
            this.lblHScore = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblGiangVien = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.Sound = new System.Windows.Forms.Button();
            this.btnHint = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuNormal
            // 
            this.mnuNormal.Index = 0;
            this.mnuNormal.Shortcut = System.Windows.Forms.Shortcut.F2;
            this.mnuNormal.Text = "&Cơ bản";
            this.mnuNormal.Click += new System.EventHandler(this.mnuNormal_Click);
            // 
            // mnuTime
            // 
            this.mnuTime.Index = 1;
            this.mnuTime.Shortcut = System.Windows.Forms.Shortcut.F3;
            this.mnuTime.Text = "&Đếm thời gian";
            this.mnuTime.Click += new System.EventHandler(this.mnuTime_Click);
            // 
            // mnuStep
            // 
            this.mnuStep.Index = 2;
            this.mnuStep.Shortcut = System.Windows.Forms.Shortcut.F4;
            this.mnuStep.Text = "&Đếm bước";
            this.mnuStep.Click += new System.EventHandler(this.mnuStep_Click);
            // 
            // mnuNewGame
            // 
            this.mnuNewGame.Index = 1;
            this.mnuNewGame.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuNormal,
            this.mnuTime,
            this.mnuStep,
            this.mnuReplay});
            this.mnuNewGame.Shortcut = System.Windows.Forms.Shortcut.CtrlN;
            this.mnuNewGame.Text = "&Trò chơi mới";
            // 
            // mnuReplay
            // 
            this.mnuReplay.Index = 3;
            this.mnuReplay.Shortcut = System.Windows.Forms.Shortcut.F12;
            this.mnuReplay.Text = "Chơi &lại";
            this.mnuReplay.Click += new System.EventHandler(this.mnuReplay_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Index = 2;
            this.mnuExit.Shortcut = System.Windows.Forms.Shortcut.AltF4;
            this.mnuExit.Text = "Th&oát";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem3,
            this.mnuNewGame,
            this.mnuExit});
            this.menuItem1.Text = "&Lựa chọn";
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 0;
            this.menuItem3.Text = "Trang chủ";
            this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // mnuSaveCurrent
            // 
            this.mnuSaveCurrent.Index = 0;
            this.mnuSaveCurrent.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
            this.mnuSaveCurrent.Text = "&Lưu trạng thái đang chơi";
            this.mnuSaveCurrent.Click += new System.EventHandler(this.mnuSaveCurrent_Click);
            // 
            // mnuLoadgame
            // 
            this.mnuLoadgame.Index = 1;
            this.mnuLoadgame.Shortcut = System.Windows.Forms.Shortcut.CtrlL;
            this.mnuLoadgame.Text = "&Mở lại lần chơi gần đây";
            this.mnuLoadgame.Click += new System.EventHandler(this.mnuLoadgame_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuSaveCurrent,
            this.mnuLoadgame});
            this.menuItem2.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
            this.menuItem2.Text = "Trò &chơi";
            // 
            // mnuAbout
            // 
            this.mnuAbout.Index = 1;
            this.mnuAbout.Shortcut = System.Windows.Forms.Shortcut.CtrlF12;
            this.mnuAbout.Text = "T&hông tin";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // mnuInstructions
            // 
            this.mnuInstructions.Index = 0;
            this.mnuInstructions.Shortcut = System.Windows.Forms.Shortcut.F1;
            this.mnuInstructions.Text = "&Hướng dẫn";
            this.mnuInstructions.Click += new System.EventHandler(this.mnuInstructions_Click);
            // 
            // menuItem9
            // 
            this.menuItem9.Index = 2;
            this.menuItem9.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuInstructions,
            this.mnuAbout});
            this.menuItem9.Text = "T&rợ giúp";
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem2,
            this.menuItem9});
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnStart.Location = new System.Drawing.Point(62, 28);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(88, 26);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "&Bắt đầu";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(6, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Thời gian :";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(6, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số clicks :";
            // 
            // lblYourtime
            // 
            this.lblYourtime.AutoSize = true;
            this.lblYourtime.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourtime.ForeColor = System.Drawing.Color.Red;
            this.lblYourtime.Location = new System.Drawing.Point(88, 168);
            this.lblYourtime.Name = "lblYourtime";
            this.lblYourtime.Size = new System.Drawing.Size(49, 19);
            this.lblYourtime.TabIndex = 3;
            this.lblYourtime.Text = "0 giây";
            // 
            // lblClicks
            // 
            this.lblClicks.AutoSize = true;
            this.lblClicks.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClicks.ForeColor = System.Drawing.Color.Red;
            this.lblClicks.Location = new System.Drawing.Point(88, 191);
            this.lblClicks.Name = "lblClicks";
            this.lblClicks.Size = new System.Drawing.Size(17, 19);
            this.lblClicks.TabIndex = 0;
            this.lblClicks.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.BackColor = System.Drawing.Color.White;
            this.lblTen.ForeColor = System.Drawing.Color.Blue;
            this.lblTen.Location = new System.Drawing.Point(289, 530);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(75, 13);
            this.lblTen.TabIndex = 6;
            this.lblTen.Text = "Memory Game";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 549);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(828, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPause.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnPause.Location = new System.Drawing.Point(62, 60);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(88, 26);
            this.btnPause.TabIndex = 1;
            this.btnPause.Text = "Tạm &dừng";
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // lable3
            // 
            this.lable3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lable3.Location = new System.Drawing.Point(6, 224);
            this.lable3.Name = "lable3";
            this.lable3.Size = new System.Drawing.Size(111, 18);
            this.lable3.TabIndex = 143;
            this.lable3.Text = "Điểm của bạn:";
            // 
            // lable4
            // 
            this.lable4.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lable4.Location = new System.Drawing.Point(6, 246);
            this.lable4.Name = "lable4";
            this.lable4.Size = new System.Drawing.Size(89, 18);
            this.lable4.TabIndex = 143;
            this.lable4.Text = "Điểm cao:";
            // 
            // lblYScore
            // 
            this.lblYScore.AutoSize = true;
            this.lblYScore.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYScore.ForeColor = System.Drawing.Color.Red;
            this.lblYScore.Location = new System.Drawing.Point(118, 223);
            this.lblYScore.Name = "lblYScore";
            this.lblYScore.Size = new System.Drawing.Size(17, 19);
            this.lblYScore.TabIndex = 146;
            this.lblYScore.Text = "0";
            // 
            // lblHScore
            // 
            this.lblHScore.AutoSize = true;
            this.lblHScore.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHScore.ForeColor = System.Drawing.Color.Red;
            this.lblHScore.Location = new System.Drawing.Point(100, 245);
            this.lblHScore.Name = "lblHScore";
            this.lblHScore.Size = new System.Drawing.Size(17, 19);
            this.lblHScore.TabIndex = 146;
            this.lblHScore.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PapayaWhip;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblYourtime);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnPause);
            this.groupBox1.Controls.Add(this.lblClicks);
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Controls.Add(this.lable3);
            this.groupBox1.Controls.Add(this.lblYScore);
            this.groupBox1.Controls.Add(this.lblHScore);
            this.groupBox1.Controls.Add(this.lable4);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(608, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 326);
            this.groupBox1.TabIndex = 147;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin về người chơi";
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(20, 130);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(151, 26);
            this.lblName.TabIndex = 147;
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(5, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 147;
            this.label3.Text = "Tên người chơi:";
            // 
            // lblGiangVien
            // 
            this.lblGiangVien.AutoSize = true;
            this.lblGiangVien.BackColor = System.Drawing.Color.Transparent;
            this.lblGiangVien.Location = new System.Drawing.Point(169, 496);
            this.lblGiangVien.Name = "lblGiangVien";
            this.lblGiangVien.Size = new System.Drawing.Size(512, 13);
            this.lblGiangVien.TabIndex = 148;
            this.lblGiangVien.Text = "Trò chơi này được viết theo đề tài đồ án môn Lập trình trực quan. Giảng viên hướn" +
    "g dẫn: Huỳnh Tuấn Anh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(78, 462);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 155;
            this.label2.Text = "Thời gian đã qua:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(545, 312);
            this.label1.TabIndex = 151;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(124, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(596, 362);
            this.groupBox2.TabIndex = 150;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hướng dẫn chơi Game";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(170, 457);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(407, 23);
            this.progressBar2.TabIndex = 156;
            // 
            // Sound
            // 
            this.Sound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Sound.Image = global::Memory_Game.Properties.Resources.Sound_;
            this.Sound.Location = new System.Drawing.Point(774, 2);
            this.Sound.Name = "Sound";
            this.Sound.Size = new System.Drawing.Size(48, 46);
            this.Sound.TabIndex = 158;
            this.Sound.UseVisualStyleBackColor = true;
            this.Sound.Click += new System.EventHandler(this.Sound_Click);
            // 
            // btnHint
            // 
            this.btnHint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHint.Image = global::Memory_Game.Properties.Resources.number_3;
            this.btnHint.Location = new System.Drawing.Point(774, 50);
            this.btnHint.Name = "btnHint";
            this.btnHint.Size = new System.Drawing.Size(48, 48);
            this.btnHint.TabIndex = 159;
            this.btnHint.UseVisualStyleBackColor = true;
            this.btnHint.Visible = false;
            this.btnHint.Click += new System.EventHandler(this.Hint_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(47, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.TabIndex = 160;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Location = new System.Drawing.Point(346, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(500, 281);
            this.pictureBox2.TabIndex = 161;
            this.pictureBox2.TabStop = false;
            // 
            // FrmMemory
            // 
            this.AcceptButton = this.btnStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(828, 571);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnHint);
            this.Controls.Add(this.Sound);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.lblGiangVien);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Menu = this.mainMenu1;
            this.Name = "FrmMemory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memory Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.FrmMemory_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuItem mnuNormal;
        private System.Windows.Forms.MenuItem mnuTime;
        private System.Windows.Forms.MenuItem mnuStep;
        private System.Windows.Forms.MenuItem mnuNewGame;
        private System.Windows.Forms.MenuItem mnuExit;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem mnuSaveCurrent;
        private System.Windows.Forms.MenuItem mnuLoadgame;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem mnuAbout;
        private System.Windows.Forms.MenuItem mnuInstructions;
        private System.Windows.Forms.MenuItem menuItem9;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblYourtime;
        private System.Windows.Forms.Label lblClicks;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuItem mnuReplay;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Label lable3;
        private System.Windows.Forms.Label lable4;
        private System.Windows.Forms.Label lblYScore;
        private System.Windows.Forms.Label lblHScore;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblGiangVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.Button Sound;
        private System.Windows.Forms.Button btnHint;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

