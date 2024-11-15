using static System.Console;
using System.Linq;

namespace _0828_Csharp
{
    #region 일반화
    class MyList<T> : IEnumerable<T>, IEnumerator<T>
    {
        private T[] array;
        int position = -1;

        public MyList()
        {
            array = new T[3];
        }

        public T this[int index]
        {
            get
            {
                return array[index];
            }

            set
            {
                if (index >= array.Length)
                {
                    Array.Resize<T>(ref array, index + 1);
                    Console.WriteLine($"Array Resized : {array.Length}");
                }

                array[index] = value;
            }
        }

        public int Length
        {
            get { return array.Length; }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() //업데이트 이후로 바뀜
        {
            return this;
        }
        public T Current
        {
            get { return array[position]; }
        }

        object System.Collections.IEnumerator.Current //업데이트 이후로 바뀜
        {
            get { return array[position]; }
        }

        public bool MoveNext()
        {
            if (position == array.Length - 1)
            {
                Reset();
                return false;
            }

            position++;
            return (position < array.Length);
        }

        public void Reset()
        {
            position = -1; ;
        }

        public void Dispose()
        {

        }
    }
    #endregion
    #region 0828 LinQ
    //public class Class
    //{
    //    public string Name { get; set; }
    //    public int[] Score { get; set; }
    //}
    #endregion
    #region 0828 LinQ
    //class Profile
    //{
    //    public string Name { get; set; }
    //    public int Height { get; set; }
    //}

    //class Profile2
    //{
    //    public string Name { get; set; }
    //    public string Product { get; set; }
    //}
    #endregion
    internal class Program
    {
        #region try catch
        //static int Divide(int divisor, int dividend)
        //{
        //    try
        //    {
        //        Console.WriteLine("Divide() 시작");
        //        return divisor / dividend;
        //    }
        //    catch (DivideByZeroException e)
        //    {
        //        Console.WriteLine("Divide() 예외 발생");
        //        throw e;
        //    }
        //    finally
        //    {
        //        Console.WriteLine("Divide()  끝");
        //    }
        //}
        #endregion
        static void Main(string[] args)
        {
            #region try catch
            //try
            //{
            //    Console.WriteLine("제수를 입력하시오 : ");
            //    String temp = ReadLine();
            //    int divisor = Convert.ToInt32(temp);

            //    Console.WriteLine("피 제수를 입력하시오 : ");
            //    temp = ReadLine();
            //    int dicidend = Convert.ToInt32(temp);

            //    Console.WriteLine($"{divisor} / {dicidend} = {Divide(divisor, dicidend)}");
            //}

            //catch (FormatException e)
            //{
            //    Console.WriteLine("에러 : " + e.Message);
            //}

            //catch (DivideByZeroException e)
            //{
            //    Console.WriteLine("에러 : " + e.Message);
            //}

            //finally
            //{
            //    Console.WriteLine("프로그램을 종료합니다.");
            //}
            #endregion
            #region 일반화
            MyList<int> list = new MyList<int>();

            for (int i = 0; i < 5; i++)
                list[i] = i;

            foreach (int e in list)
                Console.WriteLine(e);
            #endregion
            #region 0827 LinQ
            //Class[] arrClass =
            //{
            //    new Class(){Name="연두반", Score=new int[]{99, 80, 70, 24}},
            //    new Class(){Name="분홍반", Score=new int[]{60, 45, 87, 72}},
            //    new Class(){Name="파랑반", Score=new int[]{92, 30, 85, 94}},
            //    new Class(){Name="노랑반", Score=new int[]{90, 88, 0, 17}}
            //};

            //var classes = from c in arrClass
            //              from s in c.Score
            //              where s < 60
            //              orderby s ascending
            //              select new
            //              {
            //                  c.Name,
            //                  Lowest = s
            //              };
            //foreach (var c in classes)
            //{
            //    WriteLine($"낙제 : {c.Name} ({c.Lowest})");
            //}
            #endregion
            #region 0828 LinQ
            //Profile[] arrProfile =
            //{
            //    new Profile(){Name="정우성", Height=186},
            //    new Profile(){Name="김태희", Height=158},
            //    new Profile(){Name="고현정", Height=172},
            //    new Profile(){Name="이문세", Height=178},
            //    new Profile(){Name="하하", Height=171}
            //};

            //var Profiles = from profile in arrProfile
            //               group profile by profile.Height < 175 into pro
            //               select new
            //               {
            //                   Group = pro.Key == true ? "175미만" : "175이상",
            //                   Pro = pro,
            //                   Count = pro.Count(),
            //                   Max = pro.Max(profile => profile.Height),
            //                   Min = pro.Min(profile => profile.Height),
            //                   Average = pro.Average(profile => profile.Height)
            //               };

            //foreach (var profile in Profiles)
            //{
            //    WriteLine($"175 미만 ? : {profile.Group}");
            //    foreach(var mem in profile.Pro)
            //        WriteLine($">>>{mem.Name}, {mem.Height}");
            //}

            //Console.WriteLine("=======================================================");

            //foreach(var profile in Profiles)
            //{
            //    WriteLine
            //        ($"{profile.Group} - Count:{profile.Count}, Max:{profile.Max}, Min:{profile.Min}, Average:{profile.Average}");
            //}

            //Profile2[] Profile1 =
            //{
            //    new Profile2(){Name="정우성", Product="비트"},
            //    new Profile2(){Name="김태희", Product="CF"},
            //    new Profile2(){Name="김태희", Product="아이리스"},
            //    new Profile2(){Name="고현정", Product="모래시계"},
            //};

            //var finProfile = from profile in arrProfile
            //                 join profile1 in Profile1 on profile.Name equals profile1.Name
            //                 select new
            //                 {
            //                     Name = profile.Name,
            //                     Product = profile1.Product,
            //                     Height = profile.Height
            //                 };

            //WriteLine("---------내부조인 결과--------");
            //foreach (var profile in finProfile)
            //{
            //    WriteLine($"이름 : {profile.Name}, 작품 : {profile.Product}, 키 : {profile.Height}");
            //}

            //Profile2[] profile2 =
            //{
            //    new Profile2(){Name="정우성", Product="비트"},
            //    new Profile2(){Name="김태희", Product="CF"},
            //    new Profile2(){Name="김태희", Product="아이리스"},
            //    new Profile2(){Name="고현정", Product="모래시계"},
            //    new Profile2(){Name="이문세", Product="Solo 예찬"}
            //};

            //var finProfile2 = from profile in arrProfile
            //                  join pro in profile2 on profile.Name equals pro.Name into p
            //                  from pro in p.DefaultIfEmpty(new Profile2() { Product = "그딴거 없음" })
            //                  select new
            //                  {
            //                      Name = profile.Name,
            //                      Product = pro.Product,
            //                      Height = profile.Height
            //                  };

            //WriteLine("------외부조인 결과------");
            //foreach (var profile in finProfile2)
            //    WriteLine($"이름 : {profile.Name}, 작품 : {profile.Product}, 키 : {profile.Height}");
            #endregion
        }
    }
}
