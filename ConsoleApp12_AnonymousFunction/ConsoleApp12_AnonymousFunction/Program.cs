using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
/*
 * Anonymous Function - A type of method which does not contain any method name only have method body.
 * In c# anonymous function is created using 'delegate' keyword.
 */

namespace ConsoleApp12_AnonymousFunction
{
    public delegate void MyDelegate(int a); // return void 
     
    public delegate int MyDelegate1(int b); // return int

    public delegate string MyStrDelegate(string str);

    internal class Program
    {
        
        public static string Show(MyStrDelegate obj2 , string s)
        {
            return "hey " + s + obj2.Invoke(" welcome");
        }
        static void Main(string[] args)
        {
            //here we are storing the result of anonymous function in delegate 'obj' reference variable
            MyDelegate obj = delegate (int a)
            {
                a += 100;
                Console.WriteLine("Value of a : " + a);
            };
            obj.Invoke(5);


            MyDelegate1 obj1 = delegate (int b) { 
                b += 10;
                return b;
            };
            Console.WriteLine("value of b : "+obj1(1));


            //we can pass anonymus function as method parameter.
            string str = Program.Show(delegate (string s1) { return s1; }, "Anisha");
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}
