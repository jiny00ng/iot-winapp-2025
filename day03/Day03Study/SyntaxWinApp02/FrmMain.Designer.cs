namespace SyntaxWinApp02
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            BtnCheck = new Button();
            ImlForm = new ImageList(components);
            label1 = new Label();
            CboDivsion = new ComboBox();
            PicComputer = new PictureBox();
            BtnCopy = new Button();
            ((System.ComponentModel.ISupportInitialize)PicComputer).BeginInit();
            SuspendLayout();
            // 
            // BtnCheck
            // 
            BtnCheck.Image = Properties.Resources.check;
            BtnCheck.ImageAlign = ContentAlignment.MiddleLeft;
            BtnCheck.Location = new Point(444, 259);
            BtnCheck.Name = "BtnCheck";
            BtnCheck.Padding = new Padding(20, 0, 0, 0);
            BtnCheck.Size = new Size(128, 40);
            BtnCheck.TabIndex = 0;
            BtnCheck.Text = "확인";
            BtnCheck.UseVisualStyleBackColor = true;
            BtnCheck.Click += BtnCheck_Click;
            // 
            // ImlForm
            // 
            ImlForm.ColorDepth = ColorDepth.Depth32Bit;
            ImlForm.ImageStream = (ImageListStreamer)resources.GetObject("ImlForm.ImageStream");
            ImlForm.TransparentColor = Color.Transparent;
            ImlForm.Images.SetKeyName(0, "check.png");
            ImlForm.Images.SetKeyName(1, "plus.png");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(407, 15);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "종류 :";
            // 
            // CboDivsion
            // 
            CboDivsion.FormattingEnabled = true;
            CboDivsion.Items.AddRange(new object[] { "Computer", "Notebook", "Server" });
            CboDivsion.Location = new Point(451, 12);
            CboDivsion.Name = "CboDivsion";
            CboDivsion.Size = new Size(120, 23);
            CboDivsion.TabIndex = 2;
            // 
            // PicComputer
            // 
            PicComputer.BackColor = SystemColors.ActiveBorder;
            PicComputer.BorderStyle = BorderStyle.FixedSingle;
            PicComputer.Location = new Point(12, 12);
            PicComputer.Name = "PicComputer";
            PicComputer.Size = new Size(287, 287);
            PicComputer.SizeMode = PictureBoxSizeMode.StretchImage;
            PicComputer.TabIndex = 3;
            PicComputer.TabStop = false;
            // 
            // BtnCopy
            // 
            BtnCopy.Image = (Image)resources.GetObject("BtnCopy.Image");
            BtnCopy.ImageAlign = ContentAlignment.MiddleLeft;
            BtnCopy.Location = new Point(310, 259);
            BtnCopy.Name = "BtnCopy";
            BtnCopy.Padding = new Padding(20, 0, 0, 0);
            BtnCopy.Size = new Size(128, 40);
            BtnCopy.TabIndex = 0;
            BtnCopy.Text = "복사";
            BtnCopy.UseVisualStyleBackColor = true;
            BtnCopy.Click += BtnCopy_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 311);
            Controls.Add(PicComputer);
            Controls.Add(CboDivsion);
            Controls.Add(label1);
            Controls.Add(BtnCopy);
            Controls.Add(BtnCheck);
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "문법학습 윈앱02";
            ((System.ComponentModel.ISupportInitialize)PicComputer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnCheck;
        private ImageList ImlForm;
        private Label label1;
        private ComboBox CboDivsion;
        private PictureBox PicComputer;
        private Button BtnCopy;
    }
}
