using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Inheritance 
/* IMP - in first point we learn that  the child class constructor implicitly calls the parent class
 * constructor only when the parent class constructor is parameter-less.
 * if the parent class constructor is parameterised then child class constructor can not implicitly call
 * the parent class constructor
 * 
 * To overcome this problem the program have to call the parent class constructor explicitly
 * for that "base" keyword is used.
 */
namespace ConsoleApp4_Inheritance
{
    public class Class1
    {
        //Constructor - paremeterless constructor
        public Class1(int a) {
            Console.WriteLine("Parent class Constructor is called" + a);
        }
        public void Test1() {
            Console.WriteLine("Method 1");
        }

        public void Test2() {
            Console.WriteLine("Method 2");
        }
    }
}
