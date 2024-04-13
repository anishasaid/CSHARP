using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Delegates -
 * Delegate is a type-safe reference pointer.
 * It holds the reference of a method and then calls that method for execution.
 * 
 */

namespace ConsoleApp11_Delegates
{
    //delegate for AddNums(int a)
    public delegate void AddDelegate(int a);

    //delegate for SayHello(string s)
    public delegate string SayDelegate(string s);

    internal class Program
    {
        //To call the below methods need to create a object of class in Main() method
        public void AddNums(int a)
        {
            a = a + 10;
            Console.WriteLine(a);
        }

        public static string SayHello(string name)
        {
            return "hii " + name;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            /*
            //In this way we can call the methods
            p.AddNums(10);
            string s = Program.SayHello("Anisha");
            Console.WriteLine(s);
            */

            //We can also call the methods by using delegates
            AddDelegate ad = new AddDelegate(p.AddNums);
            ad(10); 

            SayDelegate sh = new SayDelegate(Program.SayHello);
            string s = sh("Anishaa");
            Console.WriteLine(s);

            Console.ReadLine();
        }
    }
}
