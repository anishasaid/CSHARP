using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Method Hiding
namespace ConsoleApp5_Polymorphism
{
    public class Parent1
    {
        public virtual void Test() //overridable method - 
        {
            Console.WriteLine("Parent class Test() Method..");
        }

        public void Show()
        {
            Console.WriteLine("Parent class Show() Method..");
        }

    }

    public class MethodHiding : Parent1
    {
        //override parant class method
        public override void Test() //Method Overriding - override keyword is used
        {
            Console.WriteLine("Child class Test() Method..");
        }

        //hiding or showing parent class method
        // new - states that we are intentionally hide the parant class method.
        public new void Show()  //Method Hiding - new keyword is used
        {
            Console.WriteLine("Child class Show() Method..");
        }

        public void CallTest() 
        { 
            base.Test();
        }

        public void CallShow()
        {
            base.Show();
        }
    
    
    
        static void Main(string[] args)
        {
            //creat instance of child class
            MethodHiding c = new MethodHiding();
            //this instance can only call its local methods
            c.Test();
            c.Show();

            //if you want to call the parent class methods  then 
            /* There are 2 ways : 
             * 1. By creating instance of parent class under child class
             * 2. By using the "base" keyword - but "this" and "base" keyword are not used in static 
             * block.
             */

            //instance of paent class
            Parent1 p = new Parent1();

            p.Test();
            p.Show();

            Console.ReadLine();

        }
             
    }
    
}
