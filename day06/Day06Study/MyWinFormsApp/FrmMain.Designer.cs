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
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            새파일NToolStripMenuItem = new ToolStripMenuItem();
            ctrlNToolStripMenuItem = new ToolStripMenuItem();
            파일불러오기LToolStripMenuItem = new ToolStripMenuItem();
            ctrlLToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            종료XToolStripMenuItem = new ToolStripMenuItem();
            ctrlXToolStripMenuItem = new ToolStripMenuItem();
            메뉴MToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            groupBox1 = new GroupBox();
            monthCalendar1 = new MonthCalendar();
            BtnDelete = new Button();
            BtnDetail = new Button();
            BtnRevise = new Button();
            BtnSave = new Button();
            TxbAllDay = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            TxbToday = new TextBox();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            groupBox4 = new GroupBox();
            BtnOpenImage = new Button();
            PicImage = new PictureBox();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicImage).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, 메뉴MToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { 새파일NToolStripMenuItem, 파일불러오기LToolStripMenuItem, toolStripMenuItem2, 종료XToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(57, 20);
            toolStripMenuItem1.Text = "파일(&F)";
            // 
            // 새파일NToolStripMenuItem
            // 
            새파일NToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ctrlNToolStripMenuItem });
            새파일NToolStripMenuItem.Name = "새파일NToolStripMenuItem";
            새파일NToolStripMenuItem.Size = new Size(180, 22);
            새파일NToolStripMenuItem.Text = "새 파일(&N)";
            // 
            // ctrlNToolStripMenuItem
            // 
            ctrlNToolStripMenuItem.Name = "ctrlNToolStripMenuItem";
            ctrlNToolStripMenuItem.Size = new Size(180, 22);
            ctrlNToolStripMenuItem.Text = "Ctrl+N";
            // 
            // 파일불러오기LToolStripMenuItem
            // 
            파일불러오기LToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ctrlLToolStripMenuItem });
            파일불러오기LToolStripMenuItem.Name = "파일불러오기LToolStripMenuItem";
            파일불러오기LToolStripMenuItem.Size = new Size(180, 22);
            파일불러오기LToolStripMenuItem.Text = "파일 불러오기(&L)";
            // 
            // ctrlLToolStripMenuItem
            // 
            ctrlLToolStripMenuItem.Name = "ctrlLToolStripMenuItem";
            ctrlLToolStripMenuItem.Size = new Size(107, 22);
            ctrlLToolStripMenuItem.Text = "Ctrl+L";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(177, 6);
            // 
            // 종료XToolStripMenuItem
            // 
            종료XToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ctrlXToolStripMenuItem });
            종료XToolStripMenuItem.Name = "종료XToolStripMenuItem";
            종료XToolStripMenuItem.Size = new Size(180, 22);
            종료XToolStripMenuItem.Text = "종료(&X)";
            // 
            // ctrlXToolStripMenuItem
            // 
            ctrlXToolStripMenuItem.Name = "ctrlXToolStripMenuItem";
            ctrlXToolStripMenuItem.Size = new Size(108, 22);
            ctrlXToolStripMenuItem.Text = "Ctrl+X";
            // 
            // 메뉴MToolStripMenuItem
            // 
            메뉴MToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem3 });
            메뉴MToolStripMenuItem.Name = "메뉴MToolStripMenuItem";
            메뉴MToolStripMenuItem.Size = new Size(62, 20);
            메뉴MToolStripMenuItem.Text = "메뉴(&M)";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(67, 22);
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(monthCalendar1);
            groupBox1.Controls.Add(BtnDelete);
            groupBox1.Controls.Add(BtnDetail);
            groupBox1.Controls.Add(BtnRevise);
            groupBox1.Controls.Add(BtnSave);
            groupBox1.Controls.Add(TxbAllDay);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(TxbToday);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Location = new Point(12, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(455, 398);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "일정관리";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(0, 21);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 5;
            // 
            // BtnDelete
            // 
            BtnDelete.Location = new Point(361, 369);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(88, 23);
            BtnDelete.TabIndex = 4;
            BtnDelete.Text = "삭제";
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnDetail
            // 
            BtnDetail.Location = new Point(237, 369);
            BtnDetail.Name = "BtnDetail";
            BtnDetail.Size = new Size(88, 23);
            BtnDetail.TabIndex = 4;
            BtnDetail.Text = "자세히 보기";
            BtnDetail.UseVisualStyleBackColor = true;
            // 
            // BtnRevise
            // 
            BtnRevise.Location = new Point(132, 369);
            BtnRevise.Name = "BtnRevise";
            BtnRevise.Size = new Size(88, 23);
            BtnRevise.TabIndex = 4;
            BtnRevise.Text = "수정";
            BtnRevise.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Location = new Point(6, 369);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(83, 23);
            BtnSave.TabIndex = 4;
            BtnSave.Text = "저장";
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // TxbAllDay
            // 
            TxbAllDay.Location = new Point(237, 155);
            TxbAllDay.Multiline = true;
            TxbAllDay.Name = "TxbAllDay";
            TxbAllDay.ScrollBars = ScrollBars.Vertical;
            TxbAllDay.Size = new Size(212, 208);
            TxbAllDay.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(237, 137);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 1;
            label2.Text = "전체 일정";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 224);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(214, 139);
            textBox1.TabIndex = 2;
            textBox1.Text = "[일정 입력]";
            // 
            // TxbToday
            // 
            TxbToday.Location = new Point(237, 37);
            TxbToday.Multiline = true;
            TxbToday.Name = "TxbToday";
            TxbToday.ScrollBars = ScrollBars.Vertical;
            TxbToday.Size = new Size(212, 97);
            TxbToday.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(237, 19);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 1;
            label1.Text = "오늘 할 일";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "MMMM dd, yyyy - dddd";
            dateTimePicker1.Location = new Point(6, 195);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(214, 23);
            dateTimePicker1.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(BtnOpenImage);
            groupBox4.Controls.Add(PicImage);
            groupBox4.Location = new Point(473, 27);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(317, 398);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "이미지 박스";
            // 
            // BtnOpenImage
            // 
            BtnOpenImage.Location = new Point(193, 369);
            BtnOpenImage.Name = "BtnOpenImage";
            BtnOpenImage.Size = new Size(118, 23);
            BtnOpenImage.TabIndex = 1;
            BtnOpenImage.Text = "이미지 불러오기";
            BtnOpenImage.UseVisualStyleBackColor = true;
            BtnOpenImage.Click += BtnOpenImage_Click;
            // 
            // PicImage
            // 
            PicImage.BackColor = SystemColors.ActiveBorder;
            PicImage.Location = new Point(6, 22);
            PicImage.Name = "PicImage";
            PicImage.Size = new Size(305, 341);
            PicImage.TabIndex = 0;
            PicImage.TabStop = false;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox4);
            Controls.Add(groupBox1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmMain";
            Text = "메인화면";
            FormClosing += FrmMain_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PicImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private StatusStrip statusStrip1;
        private GroupBox groupBox1;
        private GroupBox groupBox4;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem 메뉴MToolStripMenuItem;
        private ToolStripMenuItem 새파일NToolStripMenuItem;
        private ToolStripMenuItem 파일불러오기LToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem 종료XToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem3;
        private DateTimePicker dateTimePicker1;
        private Button BtnOpenImage;
        private PictureBox PicImage;
        private TextBox TxbToday;
        private Label label1;
        private TextBox TxbAllDay;
        private Label label2;
        private Button BtnDetail;
        private Button BtnRevise;
        private Button BtnSave;
        private TextBox textBox1;
        private MonthCalendar monthCalendar1;
        private Button BtnDelete;
        private ToolStripMenuItem ctrlNToolStripMenuItem;
        private ToolStripMenuItem ctrlLToolStripMenuItem;
        private ToolStripMenuItem ctrlXToolStripMenuItem;
    }
}
