namespace SyntaxWinApp03
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
            BtnMsg = new Button();
            Lblipain = new Label();
            TxtPain = new TextBox();
            LblPain2 = new Label();
            PainPoint = new ComboBox();
            TxtResult = new TextBox();
            BtnDisplay = new Button();
            BtnWhile = new Button();
            SuspendLayout();
            // 
            // BtnMsg
            // 
            BtnMsg.Location = new Point(497, 226);
            BtnMsg.Name = "BtnMsg";
            BtnMsg.Size = new Size(75, 23);
            BtnMsg.TabIndex = 0;
            BtnMsg.Text = "메시지";
            BtnMsg.UseVisualStyleBackColor = true;
            // 
            // Lblipain
            // 
            Lblipain.AutoSize = true;
            Lblipain.Location = new Point(12, 9);
            Lblipain.Name = "Lblipain";
            Lblipain.Size = new Size(64, 15);
            Lblipain.TabIndex = 1;
            Lblipain.Text = "통증여부 -";
            // 
            // TxtPain
            // 
            TxtPain.Location = new Point(82, 6);
            TxtPain.MaxLength = 3;
            TxtPain.Name = "TxtPain";
            TxtPain.PlaceholderText = "네 또는 아니오";
            TxtPain.Size = new Size(100, 23);
            TxtPain.TabIndex = 2;
            TxtPain.TextChanged += textBox1_TextChanged;
            TxtPain.KeyPress += TxtPain_KeyPress;
            // 
            // LblPain2
            // 
            LblPain2.AutoSize = true;
            LblPain2.Location = new Point(12, 38);
            LblPain2.Name = "LblPain2";
            LblPain2.Size = new Size(64, 15);
            LblPain2.TabIndex = 1;
            LblPain2.Text = "통증부위 -";
            // 
            // PainPoint
            // 
            PainPoint.FormattingEnabled = true;
            PainPoint.Items.AddRange(new object[] { "눈", "코", "목", "가슴", "배" });
            PainPoint.Location = new Point(82, 35);
            PainPoint.Name = "PainPoint";
            PainPoint.Size = new Size(121, 23);
            PainPoint.TabIndex = 3;
            PainPoint.Text = "부위선택";
            PainPoint.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // TxtResult
            // 
            TxtResult.Location = new Point(12, 64);
            TxtResult.Multiline = true;
            TxtResult.Name = "TxtResult";
            TxtResult.Size = new Size(560, 156);
            TxtResult.TabIndex = 4;
            // 
            // BtnDisplay
            // 
            BtnDisplay.Location = new Point(416, 226);
            BtnDisplay.Name = "BtnDisplay";
            BtnDisplay.Size = new Size(75, 23);
            BtnDisplay.TabIndex = 0;
            BtnDisplay.Text = "구구단";
            BtnDisplay.UseVisualStyleBackColor = true;
            BtnDisplay.Click += BtnDisplay_Click;
            // 
            // BtnWhile
            // 
            BtnWhile.Location = new Point(335, 226);
            BtnWhile.Name = "BtnWhile";
            BtnWhile.Size = new Size(75, 23);
            BtnWhile.TabIndex = 0;
            BtnWhile.Text = "반복";
            BtnWhile.UseVisualStyleBackColor = true;
            BtnWhile.Click += BtnWhile_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 261);
            Controls.Add(TxtResult);
            Controls.Add(PainPoint);
            Controls.Add(TxtPain);
            Controls.Add(LblPain2);
            Controls.Add(Lblipain);
            Controls.Add(BtnWhile);
            Controls.Add(BtnDisplay);
            Controls.Add(BtnMsg);
            Name = "Form1";
            Text = "문법학습 윈앱03";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnMsg;
        private Label Lblipain;
        private TextBox TxtPain;
        private Label LblPain2;
        private ComboBox PainPoint;
        private TextBox TxtResult;
        private Button BtnDisplay;
        private Button BtnWhile;
    }
}
