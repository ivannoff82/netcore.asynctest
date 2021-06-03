using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwaitCoreTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create object
            var caller = new AsyncCaller();
            Console.WriteLine("Run!");
            //Call async fake long operation
            caller.IncreaseNumber();
            //Call async loging to console          
            PrintNames(caller);
            Console.Read();
        }

        /// <summary>
        /// Async log curent index of log operation
        /// </summary>
        /// <param name="caller"></param>
        static async void PrintNames(AsyncCaller caller)
        {
            //Lamda call example
            await Task.Run(() =>
            {               
                while (caller.InProcess)
                {                  
                    Console.WriteLine($"Number = {caller.Number}");
                    Thread.Sleep(500);                   
                }
                Console.WriteLine("Enough!");
            });
        }
    }
}
