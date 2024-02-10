using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Implicit Constructor - In this we have not define any constructor so compiler calls the implicit 
 * Default constructor and initialize instance varibles with default values.
*/
namespace ConsoleApp1
{
    internal class Class1
    {
        //instace variables
        int i;
        string s;

        //Main()
        static void Main(string[] args)
        {
            //default constructor is get called
            Class1 ob = new Class1();
            Console.WriteLine("Example of implicit constructor calling");
            Console.WriteLine(ob.s);
            Console.WriteLine(ob.i);
            Console.ReadLine();
        }
    }
}
