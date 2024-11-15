using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace _0702_Csharp
{
    #region 클래스 선언
    //public class Cat
    //{
    //    public string Name; //멤버 필드
    //    public string Color;
    //    public Cat() //매개변수가 없는 생성자, 보이드 생성자라고 한다.
    //    {
    //        Name = string.Empty; //두 멤버 변수 전부 빈값으로 초기화
    //        Color = string.Empty; // " ";를 넣어도 된다.
    //    }

    //public Cat(string _name, string _color) //매개변수가 2개인 생성자
    //{
    //    Name = _name;
    //    Color = _color;
    //}

    //public Cat(string Name, string Color) //선언된 매개변수가 멤버 변수와 이름이 같을때 사용.
    //{
    //    this.Name = Name; //this가 붙은것이 멤버변수.
    //    this.Color = Color;
    //}


    //~Cat() //소멸자 : 같은 클래스의 생성자에서 생성한 것은 반드시 같은 클래스의 소멸자에서 소멸이 원칙. 
    //{
    //    WriteLine($"{Name} : 자연의 품으로 돌아갔다.");
    //}
    //public void Meow()//멤버함수가 아니면 멤버 변수를 호출 할 수 없다.
    //{
    //    WriteLine($"{Name} : 야옹");
    //}
    #endregion
    public class MainApp //internal은 같은 프로그램 안에서는 접근이 가능하다.
    {
        static void Main(string[] args)
        {
            #region 클래스 불러오기
            //Cat cat = new Cat(); //동적할당, 인스터스(객체생성)
            //cat.Name = "흰둥이"; // 객체를 생성하고 객체에 속한 변수를 따로 초기화 해줌.
            //cat.Color = "하얀색";
            //cat.Meow();
            //WriteLine($"{cat.Name} : {cat.Color}");

            //Cat cat2 = new Cat(); //보이드 생성자가 불러와진다. -> 아무것도 출력이 안됨.
            //cat2.Meow();

            //Cat cat3 = new Cat("망고","핑크"); //생성과 동시에 초기화 -> 매개변수가 2개인 생성자가 불러와진다.
            //cat3.Meow(); //즉 cat3 객체는 생성과 동시에 변수가 입력되어 초기화 된다. 
            //WriteLine($"{cat3.Name} : {cat3.Color}");

            //Cat nero = new Cat("nero", "검정색");
            //nero.Meow();
            //WriteLine($"{nero.Name} : {nero.Color}"); // 가비지 컬렉터가 자동으로 삭제하여 ~Cat이 작동안함.
            #endregion
            #region Environment클래스 사용
            //Environment.Exit(0); //프로그램 종료 매소드, 다음에 나오는 코드 적용x
            //WriteLine("출력 될까욘?");
            #endregion
            #region exe파일 실행
            //Process.Start("Notepad.exe");
            //Process.Start("Explorer.exe", "http://dotnetkorea.com");
            #endregion
            #region 로또 출력
            //WriteLine("로또 숫자 출력");
            //Random ran = new Random();
            //int[] arr = new int[6];
            //int teamp = 0;
            //for(int i =0;i<6;i++)
            //{
            //    if (i > 0 && i < 6)
            //    {
            //        teamp = ran.Next(5) +1 ;
            //        bool flag = false;
            //        for (int j = 0; j <= i; j++)
            //        {
            //            if (arr[j] == teamp)
            //                flag = true;
            //        }
            //        if (flag)
            //            --i;
            //        else
            //            arr[i] = teamp;
            //    }
            //}
            //for(int i = 0; i<6; i++)
            //{
            //    Write($"{arr[i]} ");
            //}
            //WriteLine();
            #endregion
        }
    }
}

