using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
// Asynchronous Programming - whare tasks are not perform sqencially, task with minimum execution time
// those task will execute first.

namespace ConsoleApp14_AsyncAwait
{
    internal class Class1
    {
        public static async void Task1()
        {
            await Task.Run(() => {
                Console.WriteLine("task1 started..");
                Thread.Sleep(4000);
                Console.WriteLine("task1 finished..");
            });
        }

        public static async void Task2()
        {
            await Task.Run(() => {
                Console.WriteLine("task2 started..");
                Thread.Sleep(2000);
                Console.WriteLine("task2 finished..");
            }); 
        }

        public static async void Task3()
        {
            await Task.Run(() => {
                Console.WriteLine("task3 started..");
                Thread.Sleep(10000);
                Console.WriteLine("task3 finished..");
            }); 
        }

        public static async void Task4()
        {
            await Task.Run(() => { 
            Console.WriteLine("task4 started..");
            Thread.Sleep(1000);
            Console.WriteLine("task4 finished..");
            });
        }

        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();

            Console.ReadLine();
        }
    }
}
