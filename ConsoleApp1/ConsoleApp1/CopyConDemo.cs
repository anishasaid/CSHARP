using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Copy Construcor - is used when we want to create multiple instaces with same values.
 */
namespace ConsoleApp1
{
    internal class CopyConDemo
    {
        int rollNo;
        string name;
        int marks;

        // parameterised constructor
        public CopyConDemo(int rollNo, string name, int marks)
        {
            this.rollNo = rollNo;
            this.name = name;
            this.marks = marks;
        }

        // copy constructor - it takes an object of a class as a prameter
        public CopyConDemo(CopyConDemo ob) {
            this.rollNo = ob.rollNo;
            this.name = ob.name;
            this.marks = ob.marks;
        }
        static void Main(string[] args) {

            Console.WriteLine("Parameterised constructor is executed : ");

            CopyConDemo ob1 = new CopyConDemo(1, "Anisha", 92);
            Console.WriteLine("Roll No: " + ob1.rollNo + ", Name: " + ob1.name + ", Marks: " + ob1.marks);

            Console.WriteLine("Copy constrctor is executed : ");

            CopyConDemo ob2 = new CopyConDemo(ob1);
            Console.WriteLine("Roll No: " + ob2.rollNo + ", Name: " + ob2.name + ", Marks: " + ob2.marks);
            Console.ReadLine();

        }
    }
}
