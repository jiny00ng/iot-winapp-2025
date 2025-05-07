namespace MyWinFormsApp
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            groupBox1 = new GroupBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            BtnSaveSchedule = new Button();
            BtnDeleteSchedule = new Button();
            TxtInput = new TextBox();
            DtpSchedule = new DateTimePicker();
            CalSchedule = new MonthCalendar();
            groupBox2 = new GroupBox();
            label2 = new Label();
            TxtDay = new TextBox();
            TxtAllSchedules = new TextBox();
            TxtDaySchedules = new TextBox();
            BtnViewAllSchedules = new Button();
            BtnDeleteImage = new Button();
            BtnOpenImage = new Button();
            PicImage = new PictureBox();
            button1 = new Button();
            menuStrip1 = new MenuStrip();
            MnuFile = new ToolStripMenuItem();
            MnuNewFile = new ToolStripMenuItem();
            ctrlNToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            저장SToolStripMenuItem = new ToolStripMenuItem();
            ctrlSToolStripMenuItem = new ToolStripMenuItem();
            MnuExit = new ToolStripMenuItem();
            ctrlXToolStripMenuItem = new ToolStripMenuItem();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicImage).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(BtnSaveSchedule);
            groupBox1.Controls.Add(BtnDeleteSchedule);
            groupBox1.Controls.Add(TxtInput);
            groupBox1.Controls.Add(DtpSchedule);
            groupBox1.Controls.Add(CalSchedule);
            groupBox1.Location = new Point(12, 34);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(450, 502);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "입력";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 246);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 5;
            label1.Text = "일정 입력";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.Window;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(238, 28);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(206, 197);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // BtnSaveSchedule
            // 
            BtnSaveSchedule.Location = new Point(344, 472);
            BtnSaveSchedule.Name = "BtnSaveSchedule";
            BtnSaveSchedule.Size = new Size(100, 30);
            BtnSaveSchedule.TabIndex = 3;
            BtnSaveSchedule.Text = "저장";
            BtnSaveSchedule.UseVisualStyleBackColor = true;
            BtnSaveSchedule.Click += BtnSaveSchedule_Click;
            // 
            // BtnDeleteSchedule
            // 
            BtnDeleteSchedule.Location = new Point(12, 472);
            BtnDeleteSchedule.Name = "BtnDeleteSchedule";
            BtnDeleteSchedule.Size = new Size(100, 30);
            BtnDeleteSchedule.TabIndex = 3;
            BtnDeleteSchedule.Text = "삭제";
            BtnDeleteSchedule.UseVisualStyleBackColor = true;
            BtnDeleteSchedule.Click += BtnDeleteSchedule_Click;
            // 
            // TxtInput
            // 
            TxtInput.Location = new Point(12, 264);
            TxtInput.Multiline = true;
            TxtInput.Name = "TxtInput";
            TxtInput.ScrollBars = ScrollBars.Vertical;
            TxtInput.Size = new Size(432, 202);
            TxtInput.TabIndex = 2;
            // 
            // DtpSchedule
            // 
            DtpSchedule.Location = new Point(12, 202);
            DtpSchedule.Name = "DtpSchedule";
            DtpSchedule.Size = new Size(220, 23);
            DtpSchedule.TabIndex = 1;
            // 
            // CalSchedule
            // 
            CalSchedule.Location = new Point(12, 28);
            CalSchedule.Name = "CalSchedule";
            CalSchedule.TabIndex = 0;
            CalSchedule.DateChanged += CalSchedule_DateChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(TxtDay);
            groupBox2.Controls.Add(TxtAllSchedules);
            groupBox2.Controls.Add(TxtDaySchedules);
            groupBox2.Controls.Add(BtnViewAllSchedules);
            groupBox2.Controls.Add(BtnDeleteImage);
            groupBox2.Controls.Add(BtnOpenImage);
            groupBox2.Controls.Add(PicImage);
            groupBox2.Controls.Add(button1);
            groupBox2.Location = new Point(468, 34);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(704, 502);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "일정";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(289, 25);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 7;
            label2.Text = "오늘 일정";
            // 
            // TxtDay
            // 
            TxtDay.Location = new Point(354, 22);
            TxtDay.Name = "TxtDay";
            TxtDay.Size = new Size(139, 23);
            TxtDay.TabIndex = 6;
            // 
            // TxtAllSchedules
            // 
            TxtAllSchedules.Location = new Point(6, 295);
            TxtAllSchedules.Multiline = true;
            TxtAllSchedules.Name = "TxtAllSchedules";
            TxtAllSchedules.ScrollBars = ScrollBars.Vertical;
            TxtAllSchedules.Size = new Size(692, 201);
            TxtAllSchedules.TabIndex = 5;
            // 
            // TxtDaySchedules
            // 
            TxtDaySchedules.Location = new Point(289, 51);
            TxtDaySchedules.Multiline = true;
            TxtDaySchedules.Name = "TxtDaySchedules";
            TxtDaySchedules.ScrollBars = ScrollBars.Vertical;
            TxtDaySchedules.Size = new Size(409, 207);
            TxtDaySchedules.TabIndex = 5;
            // 
            // BtnViewAllSchedules
            // 
            BtnViewAllSchedules.Location = new Point(289, 264);
            BtnViewAllSchedules.Name = "BtnViewAllSchedules";
            BtnViewAllSchedules.Size = new Size(99, 25);
            BtnViewAllSchedules.TabIndex = 3;
            BtnViewAllSchedules.Text = "전체 일정 보기";
            BtnViewAllSchedules.UseVisualStyleBackColor = true;
            BtnViewAllSchedules.Click += BtnViewAllSchedules_Click;
            // 
            // BtnDeleteImage
            // 
            BtnDeleteImage.Location = new Point(102, 264);
            BtnDeleteImage.Name = "BtnDeleteImage";
            BtnDeleteImage.Size = new Size(90, 25);
            BtnDeleteImage.TabIndex = 3;
            BtnDeleteImage.Text = "이미지 삭제";
            BtnDeleteImage.UseVisualStyleBackColor = true;
            BtnDeleteImage.Click += BtnDeleteImage_Click;
            // 
            // BtnOpenImage
            // 
            BtnOpenImage.Location = new Point(6, 264);
            BtnOpenImage.Name = "BtnOpenImage";
            BtnOpenImage.Size = new Size(90, 25);
            BtnOpenImage.TabIndex = 3;
            BtnOpenImage.Text = "이미지 열기";
            BtnOpenImage.UseVisualStyleBackColor = true;
            BtnOpenImage.Click += BtnOpenImage_Click;
            // 
            // PicImage
            // 
            PicImage.BackColor = SystemColors.ActiveBorder;
            PicImage.Location = new Point(6, 22);
            PicImage.Name = "PicImage";
            PicImage.Size = new Size(277, 236);
            PicImage.TabIndex = 4;
            PicImage.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(116, 452);
            button1.Name = "button1";
            button1.Size = new Size(8, 8);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { MnuFile });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1184, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // MnuFile
            // 
            MnuFile.DropDownItems.AddRange(new ToolStripItem[] { MnuNewFile, toolStripMenuItem2, 저장SToolStripMenuItem, MnuExit });
            MnuFile.Name = "MnuFile";
            MnuFile.Size = new Size(57, 20);
            MnuFile.Text = "파일(&F)";
            // 
            // MnuNewFile
            // 
            MnuNewFile.DropDownItems.AddRange(new ToolStripItem[] { ctrlNToolStripMenuItem });
            MnuNewFile.Name = "MnuNewFile";
            MnuNewFile.Size = new Size(119, 22);
            MnuNewFile.Text = "새 글(&N)";
            // 
            // ctrlNToolStripMenuItem
            // 
            ctrlNToolStripMenuItem.Name = "ctrlNToolStripMenuItem";
            ctrlNToolStripMenuItem.Size = new Size(110, 22);
            ctrlNToolStripMenuItem.Text = "Ctrl+N";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(116, 6);
            // 
            // 저장SToolStripMenuItem
            // 
            저장SToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ctrlSToolStripMenuItem });
            저장SToolStripMenuItem.Name = "저장SToolStripMenuItem";
            저장SToolStripMenuItem.Size = new Size(119, 22);
            저장SToolStripMenuItem.Text = "저장(&S)";
            저장SToolStripMenuItem.Click += 저장SToolStripMenuItem_Click;
            // 
            // ctrlSToolStripMenuItem
            // 
            ctrlSToolStripMenuItem.Name = "ctrlSToolStripMenuItem";
            ctrlSToolStripMenuItem.Size = new Size(112, 22);
            ctrlSToolStripMenuItem.Text = " Ctrl+S";
            // 
            // MnuExit
            // 
            MnuExit.DropDownItems.AddRange(new ToolStripItem[] { ctrlXToolStripMenuItem });
            MnuExit.Name = "MnuExit";
            MnuExit.Size = new Size(119, 22);
            MnuExit.Text = "종료(&X)";
            MnuExit.Click += MnuExit_Click;
            // 
            // ctrlXToolStripMenuItem
            // 
            ctrlXToolStripMenuItem.Name = "ctrlXToolStripMenuItem";
            ctrlXToolStripMenuItem.Size = new Size(108, 22);
            ctrlXToolStripMenuItem.Text = "Ctrl+X";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1184, 561);
            Controls.Add(menuStrip1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "일정 관리";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PicImage).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DateTimePicker DtpSchedule;
        private MonthCalendar CalSchedule;
        private Button BtnSaveSchedule;
        private Button BtnDeleteSchedule;
        private TextBox TxtInput;
        private Button button1;
        private PictureBox PicImage;
        private PictureBox pictureBox2;
        private TextBox TxtDaySchedules;
        private Button BtnOpenImage;
        private Label label2;
        private TextBox TxtDay;
        private Button BtnViewAllSchedules;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem MnuFile;
        private ToolStripMenuItem MnuNewFile;
        private ToolStripMenuItem ctrlNToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem MnuExit;
        private ToolStripMenuItem ctrlXToolStripMenuItem;
        private TextBox TxtAllSchedules;
        private Button BtnDeleteImage;
        private ToolStripMenuItem 저장SToolStripMenuItem;
        private ToolStripMenuItem ctrlSToolStripMenuItem;
    }
}
