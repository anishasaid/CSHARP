using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Delegates from Learning Never Ends YouTube

/*
 * MultiCast Delegate - Single Delegate can point to multiple methods at a time.
 */
namespace ConsoleApp11_Delegates
{
    //this delegate able to point to all the methods whch have return type - void and accepting 2 int parameters.
    public delegate void ArithmaticDelegate(int x, int y);

    internal class Class1
    {
        public static void Addition(int a, int b)
        {
            int c = a + b;
            Console.WriteLine("Addtion is : "+ c);
        }

        public static void Substraction(int a, int b)
        {
            int c = a - b;
            Console.WriteLine("Substraction is : " + c);
        }

        public static void Multiplication(int a, int b)
        {
            int c = a * b;
            Console.WriteLine("Multiplication is : " + c);
        }

        public static void Division(int a, int b)
        {
            int c = a / b;
            Console.WriteLine("Division is : " + c);
        }
        static void Main(string[] args)
        {
            ArithmaticDelegate ad = new ArithmaticDelegate(Class1.Addition);
            ad(10, 10); // output - 20

            //now delegate is pointing substraction method
            ad = Substraction;
            ad.Invoke(20, 10); //output - 10

            ad = Multiplication;
            ad.Invoke(20, 10); // output - 200

            ad = Division; 
            ad.Invoke(20, 10); // output - 2

            Console.ReadLine();
        }
    }
}
