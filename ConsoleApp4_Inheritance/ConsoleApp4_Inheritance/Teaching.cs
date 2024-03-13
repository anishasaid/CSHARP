using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//this class have total 8 variables 
// 2 from staff + 2 its own + staff extends person so 4 from person
//2 + 2 + 8 
namespace ConsoleApp4_Inheritance
{
    public class Teaching : Staff
    {
        public int salary;
        public string qualification;
        public string subject;
    }
}
