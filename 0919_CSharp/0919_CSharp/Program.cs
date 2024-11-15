using static System.Console;
using System.Threading.Tasks;
using System.Threading;

namespace _0919_CSharp
{
    /*
    사용자 작업관리자를 이용해 프로세스는 임의로 강제로 종료할 수 있지만 프로세스안에서 동작하는 각 스레드는 해당 방법으로 종료할 수 없다.
    동작중인 스레드를 종료하려면 Thread객체의 Abort()메서드를 쓸수는 있지만 사용하지 않는것이 좋다.
    .Net은 쓰레드의 상태를 ThreadState 열거형에 정의했다.
    */
    #region Task 사용
    class SideTask
    {
        int count;

        public SideTask(int count)
        {
            this.count = count;
        }
        public void KeepAlive()
        {
            try
            {
                while (count > 0)
                {
                    Console.WriteLine($"{count--} left");
                    Thread.Sleep(10);
                }
                Console.WriteLine("Count : 0");
            }
            catch (ThreadAbortException e)
            {
                Console.WriteLine(e);
                Thread.ResetAbort();
            }
            finally
            {
                Console.WriteLine("Clearing resource...");
            }
        }
    }
    #endregion
    internal class Program
    {
        #region 쓰레드 사용
        static void DoSomething()
        {
            for (int i = 0; i < 5; i++)
            {
                WriteLine($"DoSomething: {i}");
                Thread.Sleep(10); //Sleep() 메소드를 만나면 인수 10만큼 CPU사용을 멈춘다. (단위는 밀리초)
            } 
        }
        #endregion
        #region Task 사용

        #endregion
        static void Main(string[] args)
        {
            #region 쓰레드 사용
            //Thread t1 = new Thread(new ThreadStart(DoSomething)); //쓰레드를 생성하자마자 DoSomething함수를 할당
            //Console.WriteLine("Starting Thread...");
            //t1.Start();

            //for (int i = 0; i < 5; i++) //t1의 DoSomething 메소드가 실행되는 동시에 메인 쓰레드의 반복문도 실행 (메인은 기본적으로 쓰레드가 할당되어있는듯?)
            //{
            //    WriteLine($"Main: {i}");
            //    Thread.Sleep(10);
            //}
            //Console.WriteLine("Waiting Until thread stops...");
            //t1.Join(); //대기하는 메소드가 실행되어 스레드가 완전히 정지할 때 까지 기다린다.
            //Console.WriteLine("Finished");
            #endregion
            #region Task 사용
            SideTask task = new SideTask(100);
            Thread t1 = new Thread(new ThreadStart(task.KeepAlive));
            t1.IsBackground = false; //스레드가 백그라운드에서도 작동하는지, 포그라운드(동작하는 동안)에서만 작동하는지 나타내고 설정하는 역할

            Console.WriteLine("Starting thread...");
            t1.Start();

            Thread.Sleep(100);

            Console.WriteLine("Aborting thread..."); 
            t1.Abort(); //스레드 취소 (catch 실행)

            Console.WriteLine("Wating until thread Stops...");
            t1.Join();

            Console.WriteLine("Finished");
            #endregion
        }
    }
}
