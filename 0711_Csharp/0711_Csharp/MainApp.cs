using System;
using System.ComponentModel;
using System.Net.Cache;
using static System.Console;

namespace _0711_Csharp
{
    #region 인터페이스 선언
    interface ILogger //인터페이스 선언만 가능하다. 함수의 정의는 불가능
    {
        void writeLog(string message);

    }
    class ConsoleLogger : ILogger //ILogger 인터페이스를 상속받았다.
    { // 어떠한 클래스가 인터페이스를 상속 받으면 인터페이스 안에 선언된 함수를 강제 구현하게 만든다.
        public void writeLog(string message)
        {
            WriteLine($"{DateTime.Now.ToLocalTime} : {message}");
        }
    }
    class FileLogger : ILogger //메모장에 정보를 남길것이다.
    {
        private StreamWriter writer; //Stream : 디스크와 런타임을 연결하주는 가상의 통로
        public FileLogger(string path)
        {
            this.writer = File.CreateText(path); //해당 경로에 파일 생성
            writer.AutoFlush = true; //버퍼 플러시 -> 버퍼:런타임 데이터를 모아뒀다가 한번에 보내어 저장한다. (플러시 -> 보낸다.)
        }
        public void writeLog(string message)
        {
            writer.WriteLine($"{DateTime.Now.ToString()} {message}");
        }
    }
    class climateMonitor
    {
        private ILogger logger;
        public climateMonitor(ILogger logger) //매개변수가 하나인 생성자
        {
            this.logger = logger;
        }
        public void start()
        {
            while (true)
            {
                Write("온도를 입력해주세요 : ");
                string temperature = ReadLine();
                if (temperature == "")
                    break;
                logger.writeLog("현재온도 : " + temperature);
            }
        }
    }
    #endregion

    internal class MainApp
    {
        static void Main(string[] args)
        {
            #region 튜플
            ////컴파일러가 튜플 모양을 보고 직접 형식을 결정하도록 var를 이용해서 사용한다.
            //var tuple = (123, 456); //튜플 선언방식
            //WriteLine($"{tuple.Item1} : {tuple.Item2}");

            //var tuple2 = (Name : "박찬호", Age : "44"); //튜플 내부 변수의 인덱스를 명명할 수 있다.
            //WriteLine($"{tuple2.Name} : {tuple2.Age}");

            //var atuple = (Name : "양세찬", Age : 37); //튜플의 분해
            //var (name, age) = atuple;
            //WriteLine($"{name} : {age}");

            //var btuple = (Name: "박나래", Age: 43); // 튜플 내부 변수 일부 무시
            //var (name2,_) = btuple;
            //WriteLine($"{name2}");

            //var unname = ("슈퍼맨", 9999); //string int
            //var named = (Name: "유재석", Age: 52); //string int
            //WriteLine($"{named.Name} : {named.Age}");
            //named = unname;
            //WriteLine($"{named.Name} : {named.Age}");
            #endregion
            #region 인터페이스와 추상클래스
            climateMonitor monitor = new climateMonitor(new FileLogger("MyLog.txt"));
            monitor.start();
            #endregion
        }
    }
}
