using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Case 2 : Accessing the members of a class from child class in same project
namespace ConsoleApp2_AccessSpecifier
{
    internal class Two : Program // inhering the program class
    {
        static void Main(string[] args)
        {
            Two t = new Two();
            t.Test2(); //internal method
            t.Test3(); //protected method 
            t.Test4(); //protected internal method
            t.Test5(); //public method
            Console.ReadLine();
        }
    }
}
