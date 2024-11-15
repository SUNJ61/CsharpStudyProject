using System;
using static System.Console;

namespace _0805_Csharp
{
    #region LINQ 데이터 삽입용 프로퍼티 선언
    /*
    LINQ : 컬렉션을 편리하게 다루기위한 목적으로 만들어진 질의{Query} 언어이다.
    Language Intergrated Query(LINQ)
    데이터 베이스를 다루는 언어이다.
     ->from : 어떤 데이터를 집합에서 찾을 것인가?
               (원본 데이터로부터 범위 변수를 뽑아낸후 LINQ가 제공하는 연산자를 이용해 데이터 가공및 추출)
     ->where : 어떤 값의 데이터를 찾을 것 인가? (원본 데이터에서 필요없는 데이터를 걸러내는 필터 역할, 조건에 맞는 것을 추출.)
     ->orderby : 데이터를 어떻게 정렬할 것 인가? (데이터 정렬을 수행하는 연산자)
     ->select : 어떤 항목을 추출할 것인가? (최종 경과를 추출하는 마침표 같은 존재)
                select는 무명형식, 즉 새로운 형식을 바로 만들어 낼 수 있다.
    */
    //class Profile
    //{
    //    public string Name { get; set; } //자동 프로퍼티
    //    public int Height { get; set; } //자동 프로퍼티
    //}
    #endregion
    #region 문제
    class Car
    {
        public int Cost { get; set; }
        public int MaxSpeed { get; set; }
    }
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 프로퍼티 선언 (내용 x)
            //Profile[] arrProfile =
            //{
            //    new Profile(){ Name = "정우성", Height = 186},
            //    new Profile(){ Name = "우영우", Height = 166},
            //    new Profile(){ Name = "주현영", Height = 170},
            //    new Profile(){ Name = "하하", Height = 171},
            //    new Profile(){ Name = "이정재", Height = 182},
            //    new Profile(){ Name = "이수지", Height = 168},
            //};
            #endregion
            #region LINQ가 아닌 방식
            //List<Profile> profiles = new List<Profile>();
            //foreach (Profile profile in arrProfile)
            //{
            //    if(profile.Heght < 175) //키가 175 이하만 배열에 담는다.
            //        profiles.Add(profile);
            //}
            //profiles.Sort( //람다식 형태 (매개변수1, 매개변수2) -> { 결과식 }
            //    (profiles1, profiles2) => 
            //    {
            //        return profiles1.Heght - profiles2.Heght; //리턴이 음수로 나오면 Sort함수에 의해 서로의 인덱스가 바뀐다.
            //    });
            #endregion
            #region LINQ 방식 (select문에서 즉석으로 새로운 형식을 사용하지 않음)
            //var profiles = from profile in arrProfile //arrProfile 배열을 profile에 저장하는데
            //               where profile.Height < 175 //Height가 175보다 작은 값들만
            //               orderby profile.Height ascending //Height를 기준으로 오름차순으로
            //               select profile; //위 조건을 만족하여 저장된 profile을 반환한다.

            //foreach (Profile profile in profiles)
            //{
            //    WriteLine($"{profile.Name} : {profile.Height}");
            //}

            //int[] numbers = { 9, 2, 6, 4, 5, 3, 7, 8, 1, 0 }; //짝수만 출력하기
            //var result = from number in numbers //배열을 number에 저장하는데
            //             where number%2 == 0 //짝수만
            //             orderby number //오름차순으로 (아무것도 안적으면 기본이 오름차순)
            //             select number; //위 조건을 만족한 것을 반환한다.
            //foreach(int n in result)
            //    WriteLine($"짝수 : {n}");

            //var result1 = from n in numbers //from (조건을 만족한 값을 저장할 변수) in (원본 데이터)
            //              where n%3 == 0 //where (조건문)
            //              orderby n //orderby (정렬당하는 기준 변수) (정렬방식) <-생략시 오름차순 정렬
            //              select n; //select (반환하는 데이터)
            //foreach(int n in result1)
            //    WriteLine($"3의 배수 : {n}");
            #endregion
            #region LINQ 방식 (select문에서 즉석으로 새로운 형식을 사용)
            //var profiles = from Profile in arrProfile
            //              where Profile.Height < 175
            //              orderby Profile.Height ascending
            //              select new //즉석으로 새로운 형식을 만들어 낸다.
            //              { //키를 센치미터를 표현하는데 인치 형식으로 바꿔 출력
            //                  Name = Profile.Name,
            //                  InchHeight = Profile.Height * 0.393
            //              };//Name은 그대로 반환, Height는 0.393을 곱하여 InchHeight변수로 반환

            //foreach(var profile in profiles)
            //{
            //    WriteLine($"{profile.Name} : {profile.InchHeight}");
            //}
            #endregion
            #region 문제
            Car[] cars =
            {
            new Car() { Cost = 56, MaxSpeed = 120},
            new Car() { Cost = 70, MaxSpeed = 150},
            new Car() { Cost = 45, MaxSpeed = 180},
            new Car() { Cost = 32, MaxSpeed = 200},
            new Car() { Cost = 82, MaxSpeed = 280}
            };

            var result2 = from car in cars
                         where car.Cost >= 50 && car.MaxSpeed >= 150
                         orderby car.Cost
                         select car;
            foreach(var car in result2)
            {
                WriteLine($"COST : {car.Cost}, MaxSpeed : {car.MaxSpeed}");
            }
            #endregion
        }
    }
}
