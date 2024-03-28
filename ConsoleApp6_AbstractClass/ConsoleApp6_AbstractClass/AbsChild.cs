using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6_AbstractClass
{
    internal class AbsChild : AbsParent
    {
        //here we provide the defination for abstract methods of AbsParent class
        public override void Mul(int x, int y)
        {
            Console.WriteLine("Mul : "+x * y);
        }

        public override void Div(int x, int y)
        {
            Console.WriteLine("Div : "+x / y);
        }
        static void Main(string[] args)
        {
            AbsChild c = new AbsChild();
            Console.WriteLine("Call the mehtods with child class Object");
            c.Add(1, 2);
            c.Sub(10, 2);
            c.Mul(2 , 2);
            c.Div(8, 2);

            //here you can call the methods by using parent reference variable but 
            // you can not call the purely child class methods with parent reference variable.
            Console.WriteLine("You can call the methods with parent class reference variable also");
            AbsParent p = c;
            p.Add(100, 100);
            p.Sub(100, 50);
            p.Mul(10, 2);
            p.Div(10, 2);
            Console.ReadLine(); ;
        }
    }
}
