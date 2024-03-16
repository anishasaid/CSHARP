using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Method Overriding 
namespace ConsoleApp5_Polymorphism
{
    public class Parent
    {
        //Method overloading within the same class
        public void Show()
        {
            Console.WriteLine("Parent class show method is called...");
        }
        public void Show(int i) {
            Console.WriteLine("Parent class show(int i) mehtod is called...");
        }

        /*if you want to override this method in child class then 
         * you have to take permission form parent class.
         * 
         * The method should be declared by using the "virtual" modifier
         * The "virtual" states that - now the method is overridable
         */
        public virtual void Test()
        {
            Console.WriteLine("Parent class Test method is called...");
        }
    }
}
