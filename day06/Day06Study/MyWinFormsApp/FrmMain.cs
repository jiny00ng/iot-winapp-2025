namespace MyWinFormsApp
{
    public partial class FrmMain : Form
    {
        private OpenFileDialog DlgOpenImage; // 이미지 파일 열기용 다이얼로그

        public FrmMain()
        {
            InitializeComponent();           // 폼과 컨트롤 초기화
            DlgOpenImage = new OpenFileDialog(); // 다이얼로그 객체 생성
        }

        private void BtnOpenImage_Click(object sender, EventArgs e)
        {
            DlgOpenImage.FileName = ""; // 파일명 초기화
            DlgOpenImage.Filter = "Image Files (*.bmp; *.jpg; *.png)|*.bmp;*.jpg;*.png"; // 파일 형식 지정

            if (DlgOpenImage.ShowDialog() == DialogResult.OK) // 사용자가 파일 선택 후 "열기" 버튼을 눌렀다면
            {
                PicImage.Image = Bitmap.FromFile(DlgOpenImage.FileName); // 선택한 이미지를 불러오기
                PicImage.SizeMode = PictureBoxSizeMode.Zoom; // 이미지 크기 조정 (비율 유지하면서 PictureBox에 맞춤)
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("종료하시겠습니까?", "종료여부",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;    // 종료를 안 시키는 것
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

