using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
/*
 * Single Cast Delegate - Single Cast Delegate point to only single method at a time
 * In this the delegate is assigned to single method at a time. They are derived from System.Delegate class.
 */
namespace ConsoleApp11_Delegates
{
    public delegate int AddDelegate1(int x, int y);

    internal class Class2
    {
        public static int Additioin(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            AddDelegate1 ad = new AddDelegate1(Class2.Additioin);
            int c = ad.Invoke(10, 20);
            Console.WriteLine("Result of Addtion is : " +
                ""+c);

            Console.ReadLine();
        }
    }
}
