using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks.Sources;
using static System.Console;

namespace _0806_Csharp
{
    #region 람다식 연습
    //delegate int Del(int a, int b);
    #endregion
    #region LINQ연습
    //class Profile1
    //{
    //    public string? Name { get; set; }
    //    public int? Weight { get; set; }
    //}
    #endregion
    #region LINQ 조건 여러개 동시 출력하기
    //class Profile
    //{
    //    public string? Name { get; set; }
    //    public int Height { get; set; }
    //}
    #endregion
    #region LINQ를 이용하여 배열 쪼개기
    //class Class
    //{
    //    public string? Name { get; set; }
    //    public int[] Score { get; set; }
    //}
    #endregion
    #region LINQ표준 연산자와 Join연결 (클래스 Profile 사용)
    //class Product
    //{
    //    public string? Title { get; set; }
    //    public string? Star { get; set; }
    //}
    #endregion
    #region 연습
    //public class Student
    //{
    //    public string name { get; set; }
    //    public int score { get; set; }
    //}
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 람다식 연습
            //Del result = (int a,int b) => { return a + b; }; //델리게이트 사용
            //WriteLine(result(1,2));

            //Func<int, int, int> add = (a, b) => a + b; // 리턴이 있는 무명의 대리자 
            //WriteLine(add(1, 2));
            #endregion
            #region LINQ연습
            //Profile1[] profiles =
            //{
            //    new Profile1 {Name = "이문세" , Weight = 88},
            //    new Profile1 {Name = "비" , Weight = 73},
            //    new Profile1 {Name = "임창정" , Weight = 70},
            //    new Profile1 {Name = "주현영" , Weight = 58},
            //    new Profile1 {Name = "고은영" , Weight = 55},
            //    new Profile1 {Name = "이동훈" , Weight = 66}
            //};

            //var result = from profile in profiles
            //             where profile.Weight >= 60
            //             orderby profile.Weight descending
            //             select profile;

            //foreach (var profile in result)
            //{
            //    WriteLine($"Name : {profile.Name} Weight : {profile.Weight}KG");
            //}
            #endregion
            #region LINQ 조건을 통해 여러개 동시 출력하기
            //Profile[] arrProfile =
            //{
            //    new Profile(){ Name = "정우성", Height = 186},
            //    new Profile(){ Name = "우영우", Height = 166},
            //    new Profile(){ Name = "주현영", Height = 170},
            //    new Profile(){ Name = "하하", Height = 171},
            //    new Profile(){ Name = "이정재", Height = 182},
            //    new Profile(){ Name = "이수지", Height = 168},
            //};

            //var heightstat = from profile in arrProfile // arrProfile에 데이터를 profile에 저장.
            //                 group profile by profile.Height < 175 into g // profile에 저장된 데이터를 g라는 그룹에 profile.Height < 175 기준으로 나누어 저장한다.
            //                 //profile에 데이터가 g변수에 true false로 나누어진 key값과 그에 해당하는 데이터가 저장된다.
            //                 select new
            //                 {
            //                     Group = g.Key == true ? "175미만" : "175이상", // g변수의 키값에 따라 나누어 진다. 해당 데이터들의 그룹 변수가 저장됨.
            //                     Count = g.Count(), //g안에
            //                     Max = g.Max(profile => profile.Height),
            //                     Min = g.Min(profile => profile.Height),
            //                     Averange = g.Average(profile => profile.Height),
            //                     pro = g
            //                 };

            //foreach (var stat in heightstat)
            //{
            //    Write("{0} - Count : {1}, Max : {2} ", stat.Group, stat.Count, stat.Max);
            //    WriteLine("Min : {0}, Averange : {1}", stat.Min, stat.Averange);
            //}
            //foreach (var group in heightstat)
            //{
            //    WriteLine($"175cm 미만? : {group.Group}");
            //    foreach (var profile in group.pro)
            //    {
            //        WriteLine($">>> {profile.Name} {profile.Height}");
            //    }
            //}
            #endregion
            #region LINQ 조건을 통해 여러개로 동시 출력한다.
            //var weightstat = from profile in profiles
            //                 group profile by profile.Weight < 60 into w
            //                 select new
            //                 {
            //                     Group = w.Key == true ? "60kg 미만" : "60kg 이상",
            //                     Count = w.Count(),
            //                     Max = w.Max(profile => $"{profile.Weight}kg"),
            //                     Min = w.Min(profile => $"{profile.Weight}kg"),
            //                     Averange = w.Average(profile => profile.Weight),
            //                     value = w
            //                 };
            //foreach (var stat in weightstat)
            //{
            //    Write("{0} - Count : {1}, Max : {2} ", stat.Group, stat.Count, stat.Max);
            //    WriteLine("Min : {0}, Averange : {1}kg", stat.Min, stat.Averange);
            //}
            //foreach (var group in weightstat)
            //{
            //    WriteLine($"60kg 미만? : {group.Group}");
            //    foreach (var profile in group.value)
            //    {
            //        WriteLine($">>>> {profile.Name} {profile.Weight}kg");
            //    }
            //}
            #endregion
            #region LINQ를 이용하여 배열 쪼개기
            //Class[] arrClass =
            //{
            //    new Class{ Name = "연두반", Score = new int[] { 99,80,70,24 } },
            //    new Class{ Name = "분홍반", Score = new int[] { 60,45,70,87 } },
            //    new Class{ Name = "파랑반", Score = new int[] { 92,30,85,94 } },
            //    new Class{ Name = "노랑반", Score = new int[] { 90,88,0,17 } }
            //};

            // var classes = from c in arrClass
            //               from s in c.Score
            //               where s < 60
            //               orderby s ascending
            //               select new
            //               {
            //                   c.Name,
            //                   Lowest = s
            //               };
            //foreach(var c in classes)
            // {
            //     WriteLine($"낙제 : [{c.Name}] : ({c.Lowest})");
            // }

            //var score = from c in arrClass //내 답
            //              select new
            //              {
            //                  c.Name,
            //                  Count = c.Score.Count(),
            //                  Max = c.Score.Max(),
            //                  Min = c.Score.Min(),
            //                  Averange = c.Score.Average(),
            //              };
            //foreach(var sc in score)
            //{
            //    WriteLine($"[{sc.Name} 총 인원 수 : {sc.Count}]");
            //    Write($"최고점 : {sc.Max} 최저점 : {sc.Min} 평균 : {sc.Averange}\n");
            //}

            //WriteLine("===========================================================================");

            //var scores = arrClass //새로운 배열 만들기. (강사님 답)
            //    .SelectMany(c => c.Score)
            //    .Where(score => score >= 60 && score < 100) //60점이상 100점 미만인 점수만 필터링
            //    .ToArray(); //scores 배열에 저장
            ////LINQ 표준연산자에 where은 .Where라는 메소드가 호출된다. 이것이 원본 매소드

            //var count = scores.Count();
            //var average = scores.Average();
            //var max = scores.Max();
            //var min = scores.Min();

            //WriteLine($"60점 이상 100 미만의 점수 개수 : {count}");
            //WriteLine($"평균 : {average}");
            //WriteLine($"최고점 : {max}");
            //WriteLine($"최저점 : {min}");
            #endregion
            #region LINQ표준 연산자와 Join연결
            //Profile[] arrProfile =
            //{
            //    new Profile(){ Name = "정우성", Height = 186},
            //    new Profile(){ Name = "우영우", Height = 166},
            //    new Profile(){ Name = "주현영", Height = 170},
            //    new Profile(){ Name = "하하", Height = 171},
            //    new Profile(){ Name = "이정재", Height = 182},
            //    new Profile(){ Name = "이수지", Height = 168},
            //};

            //var profile = arrProfile
            //    .Where(profile => profile.Height < 175)
            //    .OrderBy(profile => profile.Height)
            //    .Select(profile => new
            //    {
            //        Name = profile.Name,
            //        InchHeight = profile.Height * 0.393
            //    });

            //foreach(var p in profile)
            //{
            //    WriteLine($"{p.Name} : {p.InchHeight}인치");
            //}

            //Join 조인 연결 : 서로다른 데이터(배열) 연결하기 -> 내부 조인과 외부 조인이 있다.
            //Product[] arrProduct =
            //{
            //    new Product() { Title = "비트", Star = "정우성" }, //위 arrProfile에 Nmae에 담긴 값이 같다. Join을 이용해 연결하기.
            //    new Product() { Title = "이상한변호사", Star = "우영우" },
            //    new Product() { Title = "이상한변호사", Star = "주현영" },
            //    new Product() { Title = "SNL", Star = "주현영" }, //하하만 존재하지 않는다.
            //    new Product() { Title = "암살", Star = "이정재" },
            //    new Product() { Title = "개그콘서트", Star = "이수지" },
            //};

            //var listProfile = from profile in arrProfile //내부 조인
            //                  join product in arrProduct on profile.Name equals product.Star //product에 arrProduct를 담고 profile.Name과 같은 데이터가 product.Star에 있는지 찾는다.
            //                  select new// 위에서 비교한 후 같은 데이터만 남기고 이외의 데이터는 버린다 (하하가 사라짐)
            //                  {
            //                      Name = profile.Name,
            //                      Work = product.Title,
            //                      Height = profile.Height
            //                  };
            //WriteLine("----내부조인결과----");
            //foreach(var profile in listProfile)
            //{
            //    WriteLine($"이름:{profile.Name}  작품:{profile.Work}  키:{profile.Height}cm");
            //}

            //var listProfile2 = from profile in arrProfile //외부 조인
            //                   join product in arrProduct on profile.Name equals product.Star into ps //product에 arrProduct를 담고 profile.Name과 같은 데이터가 product.Star에 있는지 찾고 ps변수에 결과를 저장.
            //                   from product in ps.DefaultIfEmpty(new Product() { Title = "존재하지 않음"}) //ps 데이터에 빈 값이 생기면 그 자리에  new Product() { Title = "존재하지 않음"}를 넣고 product변수에 저장
            //                   select new //profile.Name과 product.Star가 연결, 하하는 product.Star에 존재하지 않아 product.Title값이 존재하지 않음, 때문에 이 값을 넣어주었다.(이름은 없어도 서로 연결 되어서 자동 추가)
            //                   {//내부 조인에서는 이름이 추가 되어도 빈 데이터가 있어 삭제 됨.
            //                       Name = profile.Name,
            //                       Work = product.Title,
            //                       Height = profile.Height
            //                   };
            //WriteLine("----외부조인결과----");
            //foreach (var profile in listProfile2)
            //{
            //    WriteLine($"이름:{profile.Name}  작품:{profile.Work}  키:{profile.Height}cm");
            //}
            #endregion
            #region 연습
            //string[] names = new string[] { "abc", "kim", "peter", "Tistory", "Z" };

            //var name = from n in names
            //           where n.Length == 3
            //           select n;
            //foreach (string n in name)
            //    WriteLine(n);

            //List<Student> students = new List<Student>
            //{
            //    new Student { name = "zzz", score = 88},
            //    new Student { name = "kim", score = 50},
            //    new Student { name = "han", score = 76 },
            //    new Student { name = "park", score = 45 },
            //    new Student { name = "peter", score = 84 },
            //    new Student { name = "lee", score = 98 }
            //};

            //var result = from student in students
            //             where student.score >= 60
            //             orderby student.name ascending
            //             select student.name;

            //foreach(var student in result)
            //    WriteLine($"{student}");

            //var total = from student in students
            //            group student by student.score >= 60 into g
            //            select new
            //            {
            //                Group = g.Key == true ? "60점이상" : "60점미만",
            //                Count = g.Count(),
            //                Max = g.Max(student => student.score),
            //                Min = g.Min(student => student.score),
            //                Averange = g.Average(student => student.score)
            //            };

            //foreach (var student in total)
            //{
            //    Write("{0} - Count : {1}, Max : {2} ", student.Group, student.Count, student.Max);
            //    WriteLine("Min : {0}, Averange : {1}", student.Min, student.Averange);
            //}
            #endregion
        }
        #region 람다식 연습
        //static int Add(int a, int b) //이것을 람디식으로 바꿔라
        //{
        //    return a + b;
        //}
        #endregion
    }
}
