using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Parameterised Constructor - 
 
 */
namespace ConsoleApp1
{
    internal class ParameterisedConDemo
    {
        //instance variables
        int id;
        string name;
        bool b;

        //parameterised constructor
        public ParameterisedConDemo(int id, string name, bool b)
        {
            this.id = id;
            this.name = name;
            this.b = b;
        }

        //Main()
        static void Main(string[] args)
        {
            Console.WriteLine("Parameterised Constructor is executed : ");

            ParameterisedConDemo ob2 = new ParameterisedConDemo(1, "Anisha", true);
            Console.WriteLine("Id : " +ob2.id + " , Name : "+ob2.name+ " , boolValue : "+ ob2.b);

            ParameterisedConDemo ob3 = new ParameterisedConDemo(2, "Apeksha", false);
            Console.WriteLine("Id : " + ob3.id + " , Name : " + ob3.name + " , boolValue : " + ob3.b);
            Console.ReadLine();
        }
    }
}
