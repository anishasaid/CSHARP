using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Lambda Expression - 
 */
namespace ConsoleApp13_LambdaExpression
{
    public delegate void MyDelegate1(int num1);

    public delegate int MyDelegate2(int a);

    internal class Program
    {
        static void Main(string[] args)
        {
            //Lambda Expression - in this delegate keyword is not required
            // no need to specify type of the input

            MyDelegate1 obj1 = (a) => {   //Statement Lambda
                a = a + a;
                Console.WriteLine("Updated value of a : "+ a);
            };
            obj1(100);

            MyDelegate2 obj2 = (a) => a * a; //Expression Lambda
            Console.WriteLine("square of a : "+ obj2(5));

            Console.ReadLine();
        }
    }
}
