using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*The property name must be same as the feild name but to avoid naming colision  use '_' as prefix with feild.*/
namespace ConsoleApp10_Property
{
    public class Circle
    {
        //by default all the fields are private
        double _Radius = 12.35;

        /*
        //Set Access 
        public void SetRadius(double r)
        {
            this._Radius = r;
        }

        //Get Access
        public double GetRadius()
        {
            return _Radius;
        }
        

        /*
         * In above code you gave set and get access to the private radius 
         * but you can do the same thing by using public variable but you can not restrict the value.
         * 
         * so, to do so  you can define a property - instead of writing 2 methods you can achive the same
         * result by defining only 1 property
         */


        //property - property doesn't have braces () , it looks like a simple feild
        public double Radius
        {
            get { return _Radius; }
            // set { _Radius = value; }

            //you can also do conditional access and conditional assignment
            set
            {
                if(value > _Radius)
                {
                    _Radius = value;
                }
            }
        }
    }
}
