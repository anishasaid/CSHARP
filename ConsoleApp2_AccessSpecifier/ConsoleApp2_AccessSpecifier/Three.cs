using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Case 3 : Accessing the members of a class from non-child class in same project
namespace ConsoleApp2_AccessSpecifier
{
    internal class Three
    {
        static void Main(string[] args)
        {
            //create a object of program class and access his methods in this class
            Program p = new Program();
            p.Test2(); //internal method
            p.Test4(); //protected internal method
            p.Test5(); //public method 
            Console.ReadLine();
        }
    }
}
