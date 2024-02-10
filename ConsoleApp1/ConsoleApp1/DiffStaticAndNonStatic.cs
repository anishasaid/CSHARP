using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
// Difference Betwin Static Constructor and Non-Static Constructor
/*
 * 1. if a constructor is define with static modifier then it is called static constructor
 *    the constructor without a static modifier is called non-static or instance constructor.
 *    
 * 2. static constructor : responsible for initializing static variable
 *    non-static constructor : responsible for initializing non-static variables.
 *    
 * 3. SC : Implicitly Called
 *    Non-SC : Explicitly Called
 *    
 * 4. SC : Executed immediately 
 *    Non-SC : Execute only after creating instance of class
 *    
 * 5. SC : static constructor executes only once 
 *    Non-SC : executes zero times if zero instances are created
 *             executes "n" times if "n" instances are created
 *             
 * 6. SC : it is parameterless
 *    Non-SC : it is parameterised
 *    
 * 7. SC : overloading is not possible
 *    Non-SC : overloading is possible
 * */
namespace ConsoleApp1
{
    internal class DiffStaticAndNonStatic
    {
        static int x; // static variable
        int y;        // instance variable

        // static constructor
        static DiffStaticAndNonStatic()
        {
            Console.WriteLine("static x vlaue is : "+ x);
        }

        //non-static constructor
        DiffStaticAndNonStatic(int y)
        {
            this.y = y;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main Method is called : ");
            DiffStaticAndNonStatic ob = new DiffStaticAndNonStatic(10);
            Console.WriteLine("Value of y : "+ob.y);
            Console.ReadLine();

        }
    }
}
