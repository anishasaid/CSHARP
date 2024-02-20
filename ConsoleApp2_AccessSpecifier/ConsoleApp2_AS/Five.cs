using ConsoleApp2_AccessSpecifier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
//Case 5  :Accessing the members of a class from non-child class in different project
namespace ConsoleApp2_AS
{
    internal class Five
    {
       static void Main(string[] args)
        {
            ConsoleApp2_AccessSpecifier.Program pobj = new ConsoleApp2_AccessSpecifier.Program();
            pobj.Test5();
            Console.ReadLine();
        }
    }
}
