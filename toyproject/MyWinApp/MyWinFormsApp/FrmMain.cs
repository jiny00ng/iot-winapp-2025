using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MyWinFormsApp
{
    public partial class FrmMain : Form
    {
        private OpenFileDialog DlgOpenImage;
        private Dictionary<DateTime, string> schedules;  // 일정 저장을 위한 Dictionary
        private Dictionary<DateTime, Image> images;  // 날짜별로 이미지 저장을 위한 Dictionary

        public FrmMain()
        {
            InitializeComponent();
            DlgOpenImage = new OpenFileDialog();
            schedules = new Dictionary<DateTime, string>();  // 일정 Dictionary 초기화
            images = new Dictionary<DateTime, Image>();  // 이미지 Dictionary 초기화

            // 이벤트 핸들러 연결
            DtpSchedule.ValueChanged += DtpSchedule_ValueChanged;  // DateTimePicker 값 변경 시 호출될 이벤트 핸들러
            MnuExit.Click += MnuExit_Click;  // Exit 메뉴 클릭 시 호출될 이벤트 핸들러
        }

        // 이미지 열기
        private void BtnOpenImage_Click(object sender, EventArgs e)
        {
            DlgOpenImage.Title = "이미지 열기";
            DlgOpenImage.FileName = "";
            DlgOpenImage.Filter = "Image Files(*.bmp;*.jpg;*.png)|*.bmp;*.jpg;*.png";

            if (DlgOpenImage.ShowDialog() == DialogResult.OK)
            {
                PicImage.Image = Bitmap.FromFile(DlgOpenImage.FileName);  // 선택한 파일을 PictureBox에 표시
                PicImage.SizeMode = PictureBoxSizeMode.Zoom;  // 이미지 크기 맞춰서 표시
                DateTime selectedDate = CalSchedule.SelectionStart;  // 선택된 날짜 가져오기
                images[selectedDate] = PicImage.Image;  // 해당 날짜에 이미지 저장
            }
        }

        // 날짜 변경 시 일정 표시
        private void CalSchedule_DateChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = CalSchedule.SelectionStart;  // 선택된 날짜 가져오기
            TxtDay.Text = selectedDate.ToString("yyyy-MM-dd");

            // 선택된 날짜의 일정 표시
            if (schedules.ContainsKey(selectedDate))
            {
                TxtInput.Text = schedules[selectedDate];  // 일정 표시
            }
            else
            {
                TxtInput.Text = "";  // 일정이 없으면 텍스트 박스 비우기
            }

            // 선택된 날짜의 이미지 표시
            if (images.ContainsKey(selectedDate))
            {
                PicImage.Image = images[selectedDate];  // 해당 날짜에 저장된 이미지 표시
            }
            else
            {
                PicImage.Image = null;  // 이미지가 없으면 비워두기
            }
        }

        // 일정 저장
        private void BtnSaveSchedule_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = DtpSchedule.Value.Date;  // 선택된 날짜 가져오기
            string schedule = TxtInput.Text.Trim();  // 일정 입력값

            if (!string.IsNullOrEmpty(schedule))
            {
                // 일정 저장
                if (schedules.ContainsKey(selectedDate))
                {
                    schedules[selectedDate] = schedule;  // 기존 일정 덮어쓰기
                }
                else
                {
                    schedules.Add(selectedDate, schedule);  // 새로운 일정 추가
                }

                MessageBox.Show("일정이 저장되었습니다!", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("일정을 입력해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // 전체 일정 보기
        private void BtnViewAllSchedules_Click(object sender, EventArgs e)
        {
            string allSchedules = string.Join(Environment.NewLine, schedules.Select(kv => $"{kv.Key:yyyy-MM-dd}: {kv.Value}"));
            TxtAllSchedules.Text = allSchedules;  // 전체 일정 표시
        }

        // 일정 삭제
        private void BtnDeleteSchedule_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = DtpSchedule.Value.Date;  // 선택된 날짜 가져오기

            if (schedules.ContainsKey(selectedDate))
            {
                schedules.Remove(selectedDate);  // 일정 삭제
                TxtInput.Clear();  // 텍스트박스 비우기
                PicImage.Image = null;  // 이미지 삭제
                MessageBox.Show("일정이 삭제되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("선택된 날짜에 일정이 없습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // 종료 메뉴 클릭 시
        private void MnuExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("종료하시겠습니까?", "종료여부",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.FormClosing -= FrmMain_FormClosing; // 폼클로징 이벤트를 삭제
                Application.Exit(); // 프로그램 완전 종료
            }
        }

        // 폼 종료 시 확인
        private void FrmMain_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("종료하시겠습니까?", "종료여부",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;    // 종료를 안 시키는 것
            }
        }
    }
}
