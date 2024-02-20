using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Access Specifier 

//Case 1 : Accessing the members of a class form same class in same project
namespace ConsoleApp2_AccessSpecifier
{
    public class Program
    {
        //private - Accessible within the class only
        private void Test1()
        {
            Console.WriteLine("Private Method");
        }

        //internal - Accessible within the project only
        internal void Test2()
        {
            Console.WriteLine("Internal Mrthod");
        }

        //protected - Accessible within the class and its subclasses of same project and different project also
        protected void Test3()
        {
            Console.WriteLine("Protected Method");
        }
        //protected internal - its a combination of protected and internal
        //in any class if protected or internal any one of them is accessible then protected internal is accessible
        protected internal void Test4()
        {
            Console.WriteLine("Protected Internal Method");
        }

        //public - Accessible anywhere
        public void Test5()
        {
            Console.WriteLine("Public Method");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Test1(); //private method
            p.Test2(); //internal method
            p.Test3(); //protectd method
            p.Test4(); //protected internal method 
            p.Test5(); //public method
            Console.ReadLine();
        }
    }
}
