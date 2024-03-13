using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
//this class have total 7 vriables 
//4 form person bz. staff extends person + 2 form staff + 1 its own
namespace ConsoleApp4_Inheritance
{
    public  class NonTeaching : Staff
    {
        string departmentName;

        public void Main(string[] args)
        {
      
            NonTeaching n = new NonTeaching();

            n.id = 1;
            n.name = "Anisha";
            n.address = "pune";
            n.phone = "7894561234";
            n.designation = "HOD";
            n.departmentName = "comp";
            n.salary = 90000;

            Console.WriteLine("Id : " + n.id + ", Name : " + n.name + ", Address: " + n.address + ", Phone: " + n.phone + ", Designation: " + n.designation + ", Department: " + n.departmentName);
            Console.ReadLine();
                 

            
        }
    }
}
