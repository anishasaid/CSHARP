using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Case 4 : Accessing the members of a class form child class in differernt project
namespace ConsoleApp2_AS
{
    internal class Four : ConsoleApp2_AccessSpecifier.Program
    {
        static void Main(string[] args)
        {
            Four f = new Four();
            f.Test3(); // protected method
            f.Test4(); //protected internal method 
            f.Test5(); //public method
            Console.ReadLine();
        }
    }
}
