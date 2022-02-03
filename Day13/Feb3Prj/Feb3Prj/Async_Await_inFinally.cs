using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb3Prj
{
    class Async_Await_inFinally
    {
        static void Main()
        {
            addAsync();
            Console.Read();
        }
        async static Task addAsync()
        {
            try
            {
                int[] arr = new int[5];
                arr[10] = 2;
            }
            catch(Exception e)
            {
                //use await in catch 
                await otherException();
                Console.WriteLine("Waiting for some task completion");
            }
            finally
            {
                await releaseResource();
            }
        }

        async static Task otherException()
        {
            Console.WriteLine("There was an Index out of Range Exception in the array in an array");
        }
        async static Task releaseResource()
        {
            Console.WriteLine("All alloted resource has been released ");
        }
    }
}
