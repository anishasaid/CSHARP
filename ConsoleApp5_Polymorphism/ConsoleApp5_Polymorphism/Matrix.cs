using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
// Operator Overloading 
namespace ConsoleApp5_Polymorphism
{
    internal class Matrix
    {
        int a, b, c, d;

        Matrix(int a, int b, int c, int d) {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }

        //Operator Overridig 
        public static Matrix operator +(Matrix obj1, Matrix obj2) 
        {
            Matrix obj = new Matrix(obj1.a + obj2.a, obj1.b + obj2.b, obj1.c + obj2.c , obj1.d + obj2.d);
            return obj; //this obj is return in matix m3 
        }

        //override the toString method - to print the matix
        public override string ToString()
        {
            return  a + " " + b + "\n" +c + " " + d;

        }

        //Main() mathod
        static void Main(string[] args)
        {
            Matrix m1 = new Matrix(1,2,3,4);
            Matrix m2 = new Matrix(1, 2, 3, 4);
            Matrix m3 = m1 + m2;
            Console.WriteLine(m3); // it will print you the class name and not matrix
            Console.ReadLine();
        }
    }
}
