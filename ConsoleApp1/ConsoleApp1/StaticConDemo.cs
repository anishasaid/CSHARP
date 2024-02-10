using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Static Constructor - 
 * 
 * 1. is used to initialize the static variables
 *    if you do not define any static constructor explicitly the implicit static constructor is called.
 * 2. it is called implicilty you can not called static constuctor explicitly - means you dont need to
 *    write the code for calling the static consructor .
 * 3. As you can not called it explicitly means in this case : constructor overloading is not possible.
 */
namespace ConsoleApp1
{
    internal class StaticConDemo
    {
        //static variable
        static int x ;

        // here we have not define any static constructor so implicit static constructor is get called

        //AFTER COMPILATION//
        
        /* The implicit static consructor will look like this 
         
            static StaticDemo(){
                 Console.WriteLine("X : "+ x);
            }
         */
        static void Main(string[] args) {
            Console.WriteLine("Static Constructor is execulted : " + x);
            Console.ReadLine();
        }
    }
}
