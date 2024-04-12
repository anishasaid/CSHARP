using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 
namespace ConsoleApp8_Structure
{
    internal class Program
    {
        //in class you can initialized fields at the time of decalration
        int i = 55;

        static void Main(string[] args)
        {
            // in a class to access the feilds the new keyword is mandatory where it is optional in c#
            Program p = new Program();
            Console.WriteLine(p.i);
        }
    }
}
