using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Feb2Prj
{
    class MultiThreadEg
    {
        static void Main()
        {
            Console.WriteLine("Main Thread Started...");

            //creating threads
           
            Thread t1 = new Thread(Method1)
            {
                Name = "Thread 1"
            };


            Thread t2 = new Thread(Method2)
            {
                Name = "Thread 2"
            };


            Thread t3 = new Thread(Method3)
            {
                Name = "Thread 3"
            };

            t1.Start();
            t2.Start();
            t3.Start();
            Console.WriteLine("MAin Thread Ended");
            Console.Read();

        }

        static void Method1()
        {
            for(int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Method 1:" +i );
            }
            Console.WriteLine("Method 2 ended...using" + " " + Thread.CurrentThread.Name);
        }

        static void Method2()
        {
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Method 2:" + i);
                if (i == 3)
                {
                    Console.WriteLine("Performin databse activity");
                    Thread.Sleep(10000);
                    Console.WriteLine("Performin databse activity");
                }
            }
            Console.WriteLine("Method 2 ended...using" + " " + Thread.CurrentThread.Name);
        }

        static void Method3()
        {
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Method 3:" + i);
            }
            Console.WriteLine("Method 2 ended...using" + " " + Thread.CurrentThread.Name);
        }
    }
}
