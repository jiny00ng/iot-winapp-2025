namespace CrIminalCheckWinApp
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
            groupBox1 = new GroupBox();
            MtbBirth = new MaskedTextBox();
            CmbGender = new ComboBox();
            TxtName = new TextBox();
            BtnSearch = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            textBox2 = new TextBox();
            PicResult = new PictureBox();
            label4 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            groupBox3 = new GroupBox();
            BtnNewRocord = new Button();
            groupBox4 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicResult).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(MtbBirth);
            groupBox1.Controls.Add(CmbGender);
            groupBox1.Controls.Add(TxtName);
            groupBox1.Controls.Add(BtnSearch);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(227, 136);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "검색";
            // 
            // MtbBirth
            // 
            MtbBirth.Location = new Point(74, 74);
            MtbBirth.Mask = "000000";
            MtbBirth.Name = "MtbBirth";
            MtbBirth.Size = new Size(147, 23);
            MtbBirth.TabIndex = 6;
            // 
            // CmbGender
            // 
            CmbGender.FormattingEnabled = true;
            CmbGender.Items.AddRange(new object[] { "남성", "여성" });
            CmbGender.Location = new Point(74, 45);
            CmbGender.Name = "CmbGender";
            CmbGender.Size = new Size(147, 23);
            CmbGender.TabIndex = 2;
            // 
            // TxtName
            // 
            TxtName.Location = new Point(74, 16);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(147, 23);
            TxtName.TabIndex = 1;
            // 
            // BtnSearch
            // 
            BtnSearch.Location = new Point(6, 103);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(215, 27);
            BtnSearch.TabIndex = 4;
            BtnSearch.Text = "검색";
            BtnSearch.UseVisualStyleBackColor = true;
            BtnSearch.Click += BtnSearch_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 77);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 0;
            label3.Text = "생년월일 :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 48);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 0;
            label2.Text = "성별 :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 19);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "이름 :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(PicResult);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(245, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(327, 143);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "개인정보";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(188, 16);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(133, 120);
            textBox2.TabIndex = 1;
            // 
            // PicResult
            // 
            PicResult.BackColor = SystemColors.ActiveBorder;
            PicResult.Location = new Point(6, 16);
            PicResult.Name = "PicResult";
            PicResult.Size = new Size(120, 120);
            PicResult.TabIndex = 0;
            PicResult.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(144, 19);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 0;
            label4.Text = "이름 :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(132, 121);
            label8.Name = "label8";
            label8.Size = new Size(50, 15);
            label8.TabIndex = 0;
            label8.Text = "주소지 :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(132, 96);
            label7.Name = "label7";
            label7.Size = new Size(50, 15);
            label7.TabIndex = 0;
            label7.Text = "몸무게 :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(144, 70);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 0;
            label6.Text = "신장 :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(144, 45);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 0;
            label5.Text = "나이 :";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(BtnNewRocord);
            groupBox3.Location = new Point(12, 154);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(227, 150);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "신규 범죄 기록";
            // 
            // BtnNewRocord
            // 
            BtnNewRocord.Location = new Point(6, 117);
            BtnNewRocord.Name = "BtnNewRocord";
            BtnNewRocord.Size = new Size(215, 27);
            BtnNewRocord.TabIndex = 5;
            BtnNewRocord.Text = "신규 범죄 기록 추가";
            BtnNewRocord.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Location = new Point(245, 161);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(327, 143);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "범죄 이력";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 311);
            Controls.Add(groupBox4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "범죄 기록 확인";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PicResult).EndInit();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox TxtName;
        private Button BtnSearch;
        private Label label2;
        private Label label1;
        private GroupBox groupBox3;
        private Label label3;
        private ComboBox CmbGender;
        private PictureBox PicResult;
        private Label label4;
        private Label label7;
        private Label label6;
        private Label label5;
        private GroupBox groupBox4;
        private Label label8;
        private Button BtnNewRocord;
        private MaskedTextBox MtbBirth;
        private TextBox textBox2;
    }
}
