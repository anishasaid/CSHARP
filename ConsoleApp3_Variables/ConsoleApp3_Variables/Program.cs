using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
//Types of Variables and their Behaviour
/*
 1. Instance Variable - # To access instance variables you need to create the object/instance of a class.
                        # A seperate copy for all instances is get created. 
2. Static Variable - # If you declare any variable with "static" modifier then it is called as .....
                     OR any variable is declared in static  block then it is called as .....
                     # To access static variable you don't need a instance of a class.
                    # Only one copy is creted and it get shared among all the objects of class.
                   # It can be modifiable - you can change the value of static variable after initialization

3. Constanst Variable - # If you declared any variable with "const" keyword then it is called as .....
                       # It is necessary to initialized constant variabes at the time of declaration.
                      # Only one copy is creted and it get shared among all the objects of class.
                       # It can not be modifiable - you can not change the value of constant variable after declaraion

4. ReadOnly Variable - # If you delared any variable with "readonly" keyword then it is called as .....
                       # It is not necessary to initialize the readonly variable at time of declaration
                         You can initialize the variable through the constuctor also
                      # Multiple copies are created - one for each object
                      # But after initializing the varible you can not change the value of it.
 */
namespace ConsoleApp3_Variables
{
    internal class Program
    {
        //Instance Variable
        int x;

        //Static Variable
        static int y;

        //Constant Variable
        const int z = 11;

        //ReadOnly Variable
        readonly int w = 12;

        Program(int x, int w) { 
            this.x = x;
            this.w = w;
        }

        static void Main(string[] args)
        {
            //static Variable
            int a = 56; 
            //here a is static varible. you can access it without creating an insance of a class.
            Console.WriteLine(a);
            Console.WriteLine(y);

            Program p = new Program(99,88);
            Console.WriteLine("instance variable value : "+p.x +" "+"and ReadOnly variable value : "+ p.w);
            Console.ReadLine();
        }
    }
}
