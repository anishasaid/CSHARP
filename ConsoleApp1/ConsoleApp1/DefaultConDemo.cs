using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Default Constructor - If a programmer does not define any constructor explicitly then the compiler 
 * add the default construcot implicitly.
*/
namespace ConsoleApp1
{
    internal class DefaultConDemo
    {
        int id;
        string name;

        static void Main(string[] args)
        {
            Console.WriteLine("Default Constructor is executed : ");
            DefaultConDemo ob1 = new DefaultConDemo();
            Console.WriteLine(ob1.id + " " + ob1.name);
            Console.ReadLine();
        }
    }
}
