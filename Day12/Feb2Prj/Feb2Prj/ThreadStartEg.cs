using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Feb2Prj
{
    class ThreadStartEg
    {
        static void Main()
        {
            //creating threadstart delegate instance
            ThreadStart tobj = new ThreadStart(DisplayNumbers);
            //Passing the threadstatrt delegate instance to thread
            Thread t1 = new Thread(tobj);
            t1.Start();
            // Step1 and Step 2 can be rewritten as below
            Thread th1 = new Thread(new ThreadStart(DisplayNumbers));

            Thread th2 = new Thread(delegate () { DisplayNumbers(); });

            Thread th3 = new Thread(() => { DisplayNumbers(); });

            Thread th4 = new Thread(() => DisplayNumbers());

            Thread thread = new Thread(() => { for (int i = 0; i <= 5; i++) { Console.WriteLine(i); } });
            Console.Read();
        }

        static void DisplayNumbers()
        {
            for(int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Method 1 :" + " " + i);

            }
        }
    }
}
