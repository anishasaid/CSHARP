using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//In c# multiple inheritance is not supported through the classes but it is supported through the interfaces
namespace ConsoleApp7_Interfaces
{
    //First Interface
    public interface InterfaceOne
    {
        void Test();
        void Show();
    }

    //Second Interface
    public interface InterfaceTwo 
    {
        void Test();
        void Show();
    }
    
    //Class who implements the InterfaceOne and InterfaceTwo
    public class MultipleInheritanceTest : InterfaceOne, InterfaceTwo
    {
        //following are 2 ways to define the abstract methods

        //1. by using pubic 
        public void Test()
        {
            Console.WriteLine("Implement Test() of interfaces");
        }

        // 2. by not using public and by using interface name
        void InterfaceOne.Show(){
            Console.WriteLine("Implement show() of InterfaceOne");
        }

        void InterfaceTwo.Show()
        {
            Console.WriteLine("implements show() of InterfaceTwo");
        }


        //Main()
        static void Main(string[] args)
        {
            MultipleInheritanceTest ob = new MultipleInheritanceTest();
            ob.Test();

            //create reference of InterfaceOne and initialize it using object
            InterfaceOne I1 = ob;
            I1.Show();

            InterfaceTwo I2 = ob;
            I2.Show();

            Console.ReadLine();
        }
    }
}
