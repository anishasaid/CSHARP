using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Interfase
namespace ConsoleApp7_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Implementation ob = new Implementation();
            ob.Add(10, 2);
            ob.Sub(10, 2);


            Console.ReadLine();

        }
    }
}
