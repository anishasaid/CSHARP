using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Method Overloading - It is a mechanism of defining a multiple methods with same name but different 
// behaviour and Behaviour of these methods will change based on 
//1. Number of Parameters
//2. Types of Parameters
//3. Order of Parameters
namespace ConsoleApp5_Polymorphism
{
    internal class MethodOverloading
    {
        public void Test()
        {
            Console.WriteLine("1st Method : no parameter");
        }

        public void Test(int i)
        {
            Console.WriteLine("2nd Mehtod : int i parameter");
        }

        public void Test(string s)
        {
            Console.WriteLine("3rd Method : string s parameter");
        }

        public void Test(int i, string s)
        {
            Console.WriteLine("4th Method : int i , string s parameters");
        }

        public void Test(string s, int i)
        {
            Console.WriteLine("5th Method : string s, int i parameter");
        }
        static void Main(string[] args)
        {
            MethodOverloading m = new MethodOverloading();
            m.Test();
            m.Test(11);
            m.Test("Anisha");
            m.Test(6, "Apeksha");
            m.Test("pritam", 13);

            Console.ReadLine();
        }
    }
}
