// using... 네임스페이스 추가
// C, C++  #include / Python import 와 동일
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;   // 진단네임스페이스 Debug클래스 포함
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SyntaxWinApp02
{
    internal class Computer
    {
        public Computer() {
            Debug.WriteLine("[디버그]Computer 객체 생성");
            Console.WriteLine("Computer 객체 생성 - 그냥 실행");
        }

        bool powerOn;
        public void Boot() { 
            Console.WriteLine("컴퓨터 부팅!");
        }

        public virtual void ShutDown() {
            Console.WriteLine("컴퓨터 셧다운!");
        }

        public void Reset() { }
    }

    // C++에서는 다중상속이 가능
    // Java, C#은 다중상속을 막음
    internal class Notebook : Computer, IMobile, IMessageFilter, IOrderedQueryable
    {
        public Notebook()
        {
            Console.WriteLine("Notebook 객체 생성");
            base.Boot(); // 부모 클래스의 Boot() 메서드 실행
        }

        public void Call()
        {
            Console.WriteLine("노트북으로 전화 걸기");
        }
        public string GetList()
        {
            string phonelist = "010-1234-9451; 010-0000-1111;";
            return phonelist;
        }
        // 부모 클래스의 ShutDown()을 자식에서 재정의
        public override void ShutDown()
        {
            Console.WriteLine("노트북 닫기!");
        }

        bool fingerScan;    // 지문인식 

        public Type ElementType => throw new NotImplementedException();

        public Expression Expression => throw new NotImplementedException();

        public IQueryProvider Provider => throw new NotImplementedException();

        // 파라미터가 없는 메서드
        public bool HasFingerScanDevice() { return fingerScan; }

        // 파라미터가 있는 메서드
        public bool HasFingerScanDevice(bool fingerScan)
        {
            this.fingerScan = fingerScan;
            return this.fingerScan;
        }

        public bool PreFilterMessage(ref Message m)
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

    internal class Server : Computer
    {
        public string Name { get; set; }   // 이름 속성 추가
        public Server() { Console.WriteLine("Server 객체 생성"); }

        bool storage; // 스토리지
        public bool HasStorage(){ return storage; }

        // 깊은 복사 메서드
        public Server DeepCopy()
        {
            return new Server { Name = this.Name };
        }
    }
}
