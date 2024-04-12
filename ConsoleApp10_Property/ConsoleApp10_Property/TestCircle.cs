using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Property 
 * It is combination of 2 methods
 */
namespace ConsoleApp10_Property
{
    internal class TestCircle
    {
        static void Main(string[] args)
        {
            Circle c = new Circle();
            // Console.WriteLine(c.Radius); -- bz. of private you can not access it directly

            double Ans = c.Radius;
            Console.WriteLine(Ans);

            c.Radius = 12.33;
            Console.WriteLine(c.Radius);

            Console.ReadLine();
        }
    }
}
