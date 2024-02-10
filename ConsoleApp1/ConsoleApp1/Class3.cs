using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Why we need Explicit Constructor when we have Implicit Constructor already.
namespace ConsoleApp1
{
    class First {
        public int x;
    }

    class Second{
        public int x;
        public Second(int x)
        {
            this.x = x;
        }
    }
    internal class Class3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Implicit Constructor is called : bz. of this every time x is initialized with the same value. ");
            First f1 = new First();
            First f2 = new First();
            First f3 = new First();
            Console.WriteLine(f1.x +" "+ f2.x+" "+ f3.x);

            Console.WriteLine("Paraterised Constructor is called : this time every instance will initialised with different values.");
            Second s1 = new Second(10);
            Second s2 = new Second(20);
            Second s3 = new Second(30);
            Console.WriteLine(s1.x+" "+ s2.x+" "+ s3.x);

            Console.ReadLine();
        }
    }
}
