using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4_Inheritance
{
    public class Class2 : Class1 //class2 extending the class2
    {
        //constuctor 
        //here by using base(10) , we are passing 10 value to the parent class constructor.
        public Class2():base(10)
        {
            Console.WriteLine("Child class constructor is called ");
        }
        public void Test3()
        {
            Console.WriteLine("Method 3");
        }

        static void Main(string[] args)
        {
            Class2 c = new Class2();
            c.Test1();
            c.Test2();
            c.Test3();
            /*here we create a reference variable of class1 which is initialized with a child class
             * which is initialized with child class instance
             *Even we did like this then also p can not access the pure members of child class. 
             *
             *Bz. accessing the object of child class by using the parent class reference variable 
             *then we can only access the method which are common in both the classes.
             *
            */ 
            Console.WriteLine("Calling the methods by using refeence variable");
            Class1 p;
            p = c;
            p.Test1();
            p.Test2();
           // p.Test3(); ==> here we will get an error

            
            Console.ReadLine(); 
        }

    }
}
