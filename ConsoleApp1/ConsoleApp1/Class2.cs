using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Explicit Constructor
namespace ConsoleApp1
{
    internal class Class2
    {
        //instance variables
        int i = 67;
        string name = "Anisha";

        //parameterised constructor
        // Syntax - modifire constructorName( parameters name ){}
        // modifire is - public
        Class2 (int i, string name)
        {
            this.i = i;
            this.name = name;
        }

        //Main()
        static void Main(string[] args)
        {
            Console.WriteLine("Explicit Constructor calling");

            Class2 ob2 = new Class2(55,"anni");
            Console.WriteLine(ob2.i);
            Console.WriteLine(ob2.name);
            Console.ReadLine();
        }
    }
}
