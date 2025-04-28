using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace WpfStudyApp04
{
    public partial class MainWindow : Window
    {
        // 과일 목록을 저장할 ObservableCollection
        public ObservableCollection<string> fruitItems { get; set; }

        // 국가 목록을 저장할 Dictionary
        public Dictionary<string, string> countryItems { get; set; }

        // MainWindow 생성자
        public MainWindow()
        {
            InitializeComponent();
        }

        // Window_Loaded 이벤트 핸들러 (윈도우가 로드될 때 호출됨)
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // fruitItems 컬렉션 초기화 (과일 목록)
            fruitItems = new ObservableCollection<string>
            {
                "용과",
                "애플망고",
                "망고스틴",
                "자몽",
                "두리안"
            };

            // countryItems 딕셔너리 초기화 (국가 목록)
            countryItems = new Dictionary<string, string>
            {
                { "KR", "대한민국" },
                { "US", "미국" },
                { "JP", "일본" },
                { "CN", "중국" },
                { "IN", "인도" },
                { "PH", "필리핀" },
            };

            // CboCollection ComboBox에 fruitItems을 데이터 바인딩
            // 윈앱의 컨트롤.DataSource와 동일한 속성
            //CboCollection.DataContext = fruits;
            CboCollection.ItemsSource = fruitItems;

            LoadDivsionFromDatabase();

            // WPF xaml의 전체의 데이터컨텍스트에 현재값을 바인딩
            // this.DataContext = this;와 동일한 기능
            // 대신 데이터를 전잘하는 레벨은 다름
            // 현재 객체(this)를 DataContext로 설정하여 모든 데이터 바인딩을 적용
            this.DataContext = this;
            // CboFruits.DataContext = this;   // 조심해야 함.
        }

        private void LoadDivsionFromDatabase()
        {
            // DB연결 문자열(DB연결 정보)
            string connectionString = "Server=localhost;Database=bookrentalshop;Uid=root;Pwd=12345;Charset=utf8;";
            string query = "SELECT division, names, FROM divtbl";   // 언어에서 쿼리 작성시 ; 사용 안됨

            List<KeyValuePair<string, string>> divisions = new List<KeyValuePair<string, string>>();

            // DB연걸, 처리, 할당. using을 쓰면 db.close()를 using문이 대신 실행
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        var division = reader.GetString("division"); // reader.Getstring(0)은 지양
                        var names = reader.GetString("names");

                        divisions.Add(new KeyValuePair<string, string>(division, names));
                    }
                }
                catch (MySqlException ex)  
                {
                    MessageBox.Show($"DB연결 실패! : {ex.Message}", "오류", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                // con.Close(); // using문에는 사용할 필요X
            }   // 자동으로 conn.Close() 실행

            CboDivision.ItemsSource = divisions;
        }   

        // CboCountries ComboBox의 선택 변경 시 호출되는 이벤트 핸들러
        private void CboCountries_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Debug.WriteLine(CboCountries.SelectedItem);
            // 선택된 국가의 이름을 딕셔너리에서 가져오기
            string selectedCountry = ((KeyValuePair<string, string>)CboCountries.SelectedItem).Value;

            // 선택된 국가를 MessageBox로 표시
            MessageBox.Show(selectedCountry, "선택한 국가", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}

