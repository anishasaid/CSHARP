using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5_Polymorphism
{
    public class Child : Parent //extends parent class
    {
        //overloading parent class method in a child class
        public void Show(string s)
        {
            Console.WriteLine("Child class Show(string s) method is called...");
        }

        public override void Test()
        {
            Console.WriteLine("Child class Test() - overrided method is called...");
        }

        static void Main(string[] args)
        {
            Child c = new Child();
            c.Show();
            c.Show(10);
            c.Show("Anisha");

            c.Test();

            Console.ReadLine();
        }
    }
}
