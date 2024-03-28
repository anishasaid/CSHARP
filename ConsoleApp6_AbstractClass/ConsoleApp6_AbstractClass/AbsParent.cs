using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Abstract Class - A class which contain any one abstrct method, then the class is called ....
// abstract keyword is used to define abstract classes or methods09
namespace ConsoleApp6_AbstractClass
{
    abstract class AbsParent
    {
        // Non-Abstract Methods - method with body
        public void Add(int x, int y)
        {
            Console.WriteLine("Add: "+x + y);
        } 
        public void Sub(int x,int y) {
            Console.WriteLine("Sub: " + (x - y));
        }

        //Abstract Methods - Method with no body
        public abstract void Mul(int x,int y);
        public abstract void Div(int x,int y);
    
    }
}
