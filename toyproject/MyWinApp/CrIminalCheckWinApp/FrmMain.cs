using System.Resources;
using System;

namespace CrIminalCheckWinApp
{
    public partial class FrmMain : Form
    {
        public class Person
        {
            public string Name { get; set; }
            public string Gender { get; set; }  // "남" or "여"
            public DateTime BirthDate { get; set; }
            public int Height { get; set; }     // cm
            public int Weight { get; set; }     // kg
            public string Address { get; set; }
            public Image Photo { get; set; }

            public int Age => DateTime.Now.Year - BirthDate.Year;
        }


        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            // 예시 데이터 추가
            people.Add(new Person
            {
                Name = "홍길동",
                Gender = "남",
                BirthDate = new DateTime(1990, 5, 20),
                Height = 175,
                Weight = 70,
                Address = "서울시 마포구",
                Photo = Resources.man
            });

            people.Add(new Person
            {
                Name = "김영희",
                Gender = "여",
                BirthDate = new DateTime(1995, 10, 10),
                Height = 162,
                Weight = 55,
                Address = "부산시 해운대구",
                Photo = Resources.woman
            });

            CmbGender.Items.AddRange(new string[] { "남", "여" });
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string name = TxtName.Text.Trim();
            string gender = CmbGender.SelectedItem?.ToString();
            DateTime birthDate = MtbBirth;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(gender))
            {
                MessageBox.Show("이름과 성별을 입력하세요.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var person = people.FirstOrDefault(p =>
                p.Name == name && p.Gender == gender && p.BirthDate.Date == birthDate);

            if (person != null)
            {
                LblName.Text = person.Name;
                LblAge.Text = $"{person.Age}세";
                LblHeight.Text = $"{person.Height} cm";
                LblWeight.Text = $"{person.Weight} kg";
                LblAddress.Text = person.Address;

                PicResult.Image = person.Photo;
            }
            else
            {
                MessageBox.Show("해당 정보를 찾을 수 없습니다.", "검색 실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}