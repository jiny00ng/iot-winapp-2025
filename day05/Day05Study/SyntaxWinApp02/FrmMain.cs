namespace SyntaxWinApp02
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        int add(int x, int y)
        {
            return x + y;   // 한줄짜리
        }
        private void BtnCheck_Click(object sender, EventArgs e)
        {
            int result = add(10, 5);

            // 앞에는 대리자, 뒤에는 람다식
            Func<int, int, int> add2 = (x, y) => x + y;
            TxtLog.Text += result + "\r\n";
            TxtLog.Text += add2(10, 6) + "\r\n";

            // SayHello 함수 생성대신 
            Action<string> sayHello = name => MessageBox.Show($"안녕, {name}", "인사",
                                              MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            sayHello("유고");

            // LINQ 사용 이전
            List<int> reList = new List<int>();
            List<int> numbers = [4, 10, 1, 5, 9, 8, 6, 2, 3, 7];

            // 짝수만 추출해서 오름차순 정열을 하는 로직
            foreach (int n in numbers)
            {
                if (n % 2 == 0) // 2로 나눠서 나머지 0이면 짝수
                {
                    reList.Add(n);
                }
            }

            TxtLog.Text += "전통 짝수 리스트 > " + string.Join(" ", reList) + "\r\n";
            reList.Sort();
            TxtLog.Text += "전통 정렬 리스트 > " + string.Join(" ", reList) + "\r\n";

            // 기본 LINQ 방식 > 3줄로 위의 전통방식을 처리
            numbers = [14, 20, 11, 15, 18, 19, 16, 13, 12, 17];
            var reList2 = from n in numbers
                          where n % 2 == 0
                          orderby n
                          select n;
            TxtLog.Text += "링큐 정렬 리스트 > " + string.Join(" ", reList2) + "\r\n";

            // LINQ Method Chaining
            numbers = [24, 30, 21, 25, 28, 29, 26, 23, 22, 27];
            var reList3 = numbers.Where(n => n % 2 == 0).OrderBy(n => n);
            TxtLog.Text += "링큐 정렬 리스트 > " + string.Join(" ", reList3) + "\r\n";


        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            // UI 초기화
            TxtTest.PlaceholderText = "테스트입니다";
            TxtTest.Size = new Size(200, 23);
            TxtTest.KeyPress += TxtTest_KeyPress; // Designer에서 작업하는 것과 동일
            TxtTest.Font = new("휴먼매직체", 12, FontStyle.Italic);
        }
        private void TxtTest_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) // == 13과 동일
            {
                MessageBox.Show("엔터를 클릭했습니다.", "키프레스",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void BtnGeneric_Click(object? sender, EventArgs e)
        {
            // 기본
            Print<int>(100);
            Print<float>(3.141592f);
            Print<string>("안녕, 유고!");
            Print<bool>(false);

            // 생략가능 - 편의성을 위해서
            Print<int>(100);
            Print(3.141592f);
            Print("안녕, 유고!");
            Print(false);

            // 제네릭 클래스 사용
            Box<int> intBox = new Box<int>();
            intBox.Value = 300;
            intBox.Show();

            Box<string> strBox = new Box<string>();
            strBox.Value = "애슐리";
            strBox.Show();
        }

        public void Print<T>(T data) { Console.WriteLine(data); }
    }

    // 제네릭 클래스
    public class Box<T> // where T : struct
    { 
        public T Value { get; set; }    // 속성
        // public T value;  // 멤버변수
        public void Show()
        {
            Console.WriteLine($"Box의 값 : {Value}", "Box값",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

}
