using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace MyWinFormsApp
{
    public partial class FrmMain : Form
    {
        private OpenFileDialog DlgOpenImage;  // 이미지 파일 열기 대화 상자
        private Dictionary<DateTime, string> schedules;  // 날짜별 일정 저장
        private Dictionary<DateTime, Image> images;      // 날짜별 이미지 저장

        // 데이터 저장 경로 설정
        private readonly string dataPath = Path.Combine(Application.StartupPath, "schedules.json");
        private readonly string imageFolderPath = Path.Combine(Application.StartupPath, "Images");

        private ToolStripStatusLabel statusLabel;  // 상태 표시줄에 상태 출력

        public FrmMain()
        {
            InitializeComponent();
            DlgOpenImage = new OpenFileDialog();
            schedules = new Dictionary<DateTime, string>();
            images = new Dictionary<DateTime, Image>();

            // 이벤트 핸들러 연결
            DtpSchedule.ValueChanged += DtpSchedule_ValueChanged;
            CalSchedule.DateChanged += CalSchedule_DateChanged;
            MnuExit.Click += MnuExit_Click;
            this.FormClosing += FrmMain_FormClosing;
            this.KeyPreview = true;
            this.KeyDown += FrmMain_KeyDown;  // Ctrl+S 단축키 설정

            // 상태 표시줄 초기화
            statusLabel = new ToolStripStatusLabel("일반 상태");
            StatusStrip statusStrip = new StatusStrip();
            statusStrip.Items.Add(statusLabel);
            this.Controls.Add(statusStrip);

            // 프로그램 시작 시 데이터 불러오기
            LoadAllData();
        }

        // Ctrl+S 저장 단축키 처리
        private void FrmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                SaveAllData();
                statusLabel.Text = "저장됨: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                e.SuppressKeyPress = true;  // 삑 소리 방지
            }
            else
            {
                statusLabel.Text = "일반 상태";
            }
        }

        // 날짜 선택 변경 시 텍스트 및 이미지 표시
        private void DtpSchedule_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = DtpSchedule.Value.Date;
            CalSchedule.SetDate(selectedDate);  // 달력 동기화
            TxtDay.Text = selectedDate.ToString("yyyy-MM-dd");

            TxtInput.Text = schedules.ContainsKey(selectedDate) ? schedules[selectedDate] : "";
            PicImage.Image = images.ContainsKey(selectedDate) ? images[selectedDate] : null;
        }

        // 달력 선택 변경 시 텍스트 및 이미지 표시
        private void CalSchedule_DateChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = CalSchedule.SelectionStart;
            DtpSchedule.Value = selectedDate;  // 날짜 선택기 동기화
            TxtDay.Text = selectedDate.ToString("yyyy-MM-dd");

            TxtInput.Text = schedules.ContainsKey(selectedDate) ? schedules[selectedDate] : "";
            PicImage.Image = images.ContainsKey(selectedDate) ? images[selectedDate] : null;
        }

        // 이미지 열기 및 저장
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

        // 일정 저장 버튼
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

                // 오늘 날짜에 해당할 때만 오늘 일정란에 표시
                if (selectedDate == DateTime.Today)
                {
                    TxtDaySchedules.Text = $"{selectedDate:yyyy-MM-dd (ddd)}\r\n{schedule}";
                }
                // 상태 표시줄에 저장 시각 표시
                statusLabel.Text = "저장됨: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            }
            else
            {
                MessageBox.Show("일정을 입력해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                statusLabel.Text = "일반 상태";
            }
        }

        // 전체 일정 보기 버튼
        private void BtnViewAllSchedules_Click(object sender, EventArgs e)
        {
            string allSchedules = string.Join(Environment.NewLine + Environment.NewLine,
            schedules.Select(kv => $"{kv.Key:yyyy-MM-dd (ddd)}:\r\n{kv.Value}")
        );
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

                // 오늘 날짜의 일정이 삭제된 경우, 오늘 일정 박스도 지움
                if (selectedDate == DateTime.Today)
                {
                    TxtDaySchedules.Clear();
                }

                MessageBox.Show("일정이 삭제되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("선택된 날짜에 일정이 없습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void BtnDeleteImage_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = DtpSchedule.Value.Date;

            if (images.ContainsKey(selectedDate))
            {
                images.Remove(selectedDate);       // 이미지 딕셔너리에서 삭제
                PicImage.Image = null;             // PictureBox 초기화
                MessageBox.Show("이미지가 삭제되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("선택된 날짜에 이미지가 없습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // 종료 메뉴 클릭 시
        private void MnuExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("종료하시겠습니까?", "종료여부",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.FormClosing -= FrmMain_FormClosing; // 폼클로징 이벤트를 삭제
                SaveAllData();  // 직접 저장!
                Application.Exit(); // 프로그램 완전 종료
            }
        }

        // 폼 종료 시 확인
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("종료하시겠습니까?", "종료여부",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;    // 종료를 안 시키는 것
            }
        }

        private void 저장SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAllData();  // 수동 저장
            MessageBox.Show("일정과 이미지가 저장되었습니다.", "저장 완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // 일정 및 이미지 저장 함수
        private void SaveAllData()
        {
            Directory.CreateDirectory(imageFolderPath);
            var entries = new List<ScheduleEntry>();

            foreach (var date in schedules.Keys)
            {
                string imgPath = "";
                if (images.ContainsKey(date))
                {
                    imgPath = Path.Combine(imageFolderPath, date.ToString("yyyyMMdd") + ".png");
                    images[date].Save(imgPath);
                }

                entries.Add(new ScheduleEntry
                {
                    Date = date,
                    Schedule = schedules[date],
                    ImagePath = imgPath
                });
            }

            string json = JsonConvert.SerializeObject(entries, Formatting.Indented);
            File.WriteAllText(dataPath, json);

            if (statusLabel != null)
            {
                statusLabel.Text = "저장됨: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            }
        }
        // 프로그램 시작 시 데이터 불러오기
        private void LoadAllData()
        {
            if (!File.Exists(dataPath)) return;

            string json = File.ReadAllText(dataPath);
            var entries = JsonConvert.DeserializeObject<List<ScheduleEntry>>(json);

            foreach (var entry in entries)
            {
                schedules[entry.Date] = entry.Schedule;
                if (!string.IsNullOrEmpty(entry.ImagePath) && File.Exists(entry.ImagePath))
                {
                    images[entry.Date] = Image.FromFile(entry.ImagePath);
                }
            }
        }
    }

    // 일정 저장용 클래스 정의
    public class ScheduleEntry
    {
        public DateTime Date { get; set; }
        public string Schedule { get; set; }
        public string ImagePath { get; set; }
    }
}

