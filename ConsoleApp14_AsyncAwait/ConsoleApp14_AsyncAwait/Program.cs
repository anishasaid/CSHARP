using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

//Synchronous Programming - is a programming model where operations perform sequencially.
namespace ConsoleApp14_AsyncAwait
{
    internal class Program
    {
        public static void Task1()
        {
            Console.WriteLine("task1 started..");
            Thread.Sleep(4000);
            Console.WriteLine("task1 finished..");
        }

        public static void Task2()
        {
            Console.WriteLine("task2 started..");
            Thread.Sleep(2000);
            Console.WriteLine("task2 finished..");
        }

        public static void Task3()
        {
            Console.WriteLine("task3 started..");
            Thread.Sleep(5000);
            Console.WriteLine("task3 finished..");
        }

        public static void Task4()
        {
            Console.WriteLine("task4 started..");
            Thread.Sleep(1000);
            Console.WriteLine("task4 finished..");
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
