using static System.Console;

using System.Runtime.InteropServices; //덕타이핑

using Excel = Microsoft.Office.Interop.Excel; //엑셀에 데이터를 저장하기 위해 선언됨

using System.Linq;
using System.IO;
namespace _0808_Csharp
{
    #region dynamic형식 예시
    //형식 검사를 컴파일할 때 하지 않고 런타임할 때로 미루는 방식
    //dynamic도 데이터 형식의 일부, 다만 형식 검사를 하는 시점이 프로그램 실행 중이라는 점이 일반 데이터 형식과는 다르다.
    //class Myclass
    //{
    //    public void FuncA()
    //    {

    //    }
    //}
    #endregion
    #region 덕타이핑
    //class Duck
    //{
    //    public void Walk()
    //    {
    //        WriteLine(this.GetType()+"Duck.Walk");
    //    }
    //    public void Swim()
    //    {
    //        WriteLine(this.GetType() + "Duck.Swim");
    //    }
    //    public void Quack()
    //    {
    //        WriteLine(this.GetType() + "Duck.Quack");
    //    }
    //}
    //class Mallard : Duck
    //{}
    //class Robot
    //{
    //    public void Walk()
    //    {
    //        WriteLine(this.GetType() + "Robot.Walk");
    //    }
    //    public void Swim()
    //    {
    //        WriteLine(this.GetType() + "Robot.Swim");
    //    }
    //    public void Quack()
    //    {
    //        WriteLine(this.GetType() + "Robot.Quack");
    //    }
    //}
    #endregion
    #region 

    #endregion

    internal class Program
    {
        #region 엑셀과 연동하기
        //public static void OldWay(string[,] data, string savePath)
        //{
        //    Excel.Application exCelApp = new Excel.Application();//엑셀 컴포넌트 동적 할당.
        //    exCelApp.Workbooks.Add(Type.Missing);
        //    Excel.Worksheet worksheet =(Excel.Worksheet)exCelApp.ActiveSheet;
        //    for(int i = 0; i<data.GetLength(0); i++)
        //    {
        //        ((Excel.Range)worksheet.Cells[i + 1, 1]).Value2 = data[i,0];
        //        ((Excel.Range)worksheet.Cells[i + 1, 2]).Value2 = data[i,1];
        //    }
        //    worksheet.SaveAs(savePath + "\\shpark-book-old-xlsx", Type.Missing, Type.Missing, Type.Missing, Type.Missing);
        //    exCelApp.Quit();
        //}
        //public static void NewWay(string[,] data, string savePath) //최신버전
        //{
        //    Excel.Application exCelApp = new Excel.Application();//엑셀 컴포넌트 동적 할당.
        //    exCelApp.Workbooks.Add();
        //    Excel.Worksheet worksheet = (Excel.Worksheet)exCelApp.ActiveSheet; //엑셀의 시트를 활성화 시킨다.
        //    for (int i = 0; i < data.GetLength(0); i++)
        //    {
        //        ((Excel.Range)worksheet.Cells[i + 1, 1]).Value2 = data[i, 0];
        //        ((Excel.Range)worksheet.Cells[i + 1, 2]).Value2 = data[i, 1];
        //    }
        //    worksheet.SaveAs(savePath + "\\shpark-book-dynamic-xlsx");
        //    exCelApp.Quit();
        //}
        #endregion
        #region
        static void OnwrongPathType(string type) //경로를 못찾은 경우 발생
        {
            WriteLine($"{type} is wrong type");
            return;
        }
        #endregion
        static void Main(string[] args)
        {
            #region dynamic형식 예시
            //Myclass obj1 = new Myclass();
            //obj1.FuncA();
            ////obj1.FuncB();//해당 코드는 오류가 발생, 존재하지 않는 함수

            //dynamic obj2 = new Myclass();
            //obj2.FuncA();
            //obj2.FuncB();//해당 코드는 빌드까지는 오류 발생이 나지않음, 런타임시 오류 발생
            #endregion
            #region 덕타이핑
            //dynamic[] arr = new dynamic[] {new Duck(), new Mallard(), new Robot()}; //컴파일러 상태에서는 Robot도 덕이라고 인정.
            ////같은 Duck형태의 클래스 변수가 아니라도 Duck클래스 변수로 인정하여 배열에 담을 수 있다.
            //foreach (dynamic duck in arr)
            //{
            //    WriteLine(duck.GetType());
            //    duck.Walk();
            //    duck.Swim();
            //    duck.Quack();
            //    WriteLine();
            //}
            #endregion
            #region 엑셀과 연동하기
            ////솔루션 탐색기에 종속성 -> COM참조 추가 -> 엑셀찾아서 확인, 엑셀 컴포넌트 찾아서 우클릭 속성 -> interop형식 포함을 예로 체크
            //string savePath = System.IO.Directory.GetCurrentDirectory();
            //string[,] array = new string[,]
            //{
            //    { "유니티 버전 2020버전", "2020.07.09"},
            //    { "유니티 버전 2021버전", "2021.01.23"},
            //    { "유니티 버전 2022버전", "2022.01.07"},
            //    { "C Sharp 8.0", "2023.04.12"},
            //    { "C Sharp 으로 서버 만들기", "2023.06.12"},
            //};
            //WriteLine("유니티 버전 엑셀로 정리");
            //OldWay(array, savePath);
            //WriteLine();
            //NewWay(array, savePath);
            #endregion
            #region 파일 정보 조회
            //string directory;
            //if (args.Length < 1)
            //    directory = ",";
            //else
            //    directory = args[0];
            //WriteLine($"{directory}directory Info");
            //WriteLine("- Directories : ");
            //var directories = (from dir in Directory.GetDirectories(directory)
            //                   let info = new DirectoryInfo(dir) //let은 LINQ변수, var와 비슷한 변수라고 생각 (어떤 자료형이든 다 담을 수 있음.)
            //                   select new
            //                   {
            //                       Name = info.Name,
            //                       Attributes = info.Attributes,
            //                   }).ToList();
            //foreach(var d in directories)
            //    WriteLine($"{d.Name} {d.Attributes}");

            //WriteLine("--- Files : ");
            //var files = (from file in Directory.GetFiles(directory)
            //            let info = new FileInfo(file)
            //            select new
            //            {
            //                Name = info.Name,
            //                FileSize = info.Length,
            //                Attributes = info.Attributes
            //            }).ToList();
            //foreach (var f in files)
            //{
            //    WriteLine($"{f.Name} {f.FileSize} : {f.Attributes}");
            //}
            #endregion
            #region
            if(args.Length == 0)
            {
                WriteLine("Usage :  _0808_Csharp.exe<Path>[Type:File/Directory]");
                return;
            }
            string path = args[0];
            string type = "File";
            if(args.Length > 1)
                type = args[1];
            if(File.Exists(path) || Directory.Exists(path)) //파일이 존재하고 디렉토리 경로명도 존재한다면.
            {
                if (type == "File")
                    File.SetLastWriteTime(path, DateTime.Now);
                else if (type == "Directory")
                    Directory.CreateDirectory(path);
                else
                {
                    OnwrongPathType(path);
                    return;
                }
                WriteLine($"Update {path}  {type}");
            }
            else
            {
                if (type == "File")
                    File.Create(path).Close();
                else if (type == "Directory")
                    Directory.CreateDirectory(path);
                else
                {
                    OnwrongPathType(path);
                    return;
                }
                WriteLine($"Created {path}{type}");
            }
            #endregion
        }
    }
}
