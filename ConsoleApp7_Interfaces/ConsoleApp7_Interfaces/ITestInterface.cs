using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7_Interfaces
{
    // First Interface
    public interface ITestInterface
    {
        void Add(int x, int y);
    }

    // Second Interface 
    public interface ITestInterface2 : ITestInterface
    {
        // By default all members in interface are - public 
        void Sub(int x, int y); 
    }

    // if a class implements the interface then the class must implements the abstract method
    public class Implementation : ITestInterface, ITestInterface2
    {
        public void Add(int x, int y)
        {
            Console.WriteLine("Addition : " + (x + y));
        }

        //OR 
        // without writing public you can implements abstract class by using interface name
        void ITestInterface.Add(int x, int y){
            Console.WriteLine("Addition is : "+ (x+y));
        }


        public void Sub(int x, int y)
        {
            Console.WriteLine("Substraction : "+ (x-y));
        }


        void ITestInterface2.Sub(int x, int y) {
            Console.WriteLine("Substrction is in ITestInterface.Sub() : " + (x - y));
        }

        static void Main(string[] args)
        {
            Implementation a = new Implementation();

            //by using interface reference 
            ITestInterface i1 = a; // initialize the interface reference by class object
            i1.Add(1, 2);

            ITestInterface2 i2 = a;
            i2.Sub(20,10);
            i2.Add(20,10);  

            Console.ReadLine();
        }
    }
}
