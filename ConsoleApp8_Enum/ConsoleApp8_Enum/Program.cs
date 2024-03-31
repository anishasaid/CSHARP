using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Enumration - 
namespace ConsoleApp8_Enum
{
    public enum Days
    {
        Monday, Tuesday, Wednesday, Thursday , Friday 
    }

    //if you want to change the data type of enum then you can
    /* 
     * public enum Days : byte
     * {
     *      // You can also give a different values to this and no need to give values to all 
     *      // it will take other values automatically
     *      Monday = 1, Tuesday, Wednesday, Thursday, Friday
     * }
     */
    public class Program
    {
        //it is a property - is only business days
        public static Days MeetingDate
        {
            get;set;
        }=0;

        static void Main(string[] args)
        {
            //Console class having a property - BackgroundColor 
            //And BackgroundColor having a enum - ConsoleColor 
            //ConsoleColor is a enum which hold some supported list of color.
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Hello World");

            Days d = 0; // it will gives you a value of zero ans monday
            Console.WriteLine(d);

            //You can not write like
            /*
             * Days d2 = 1;   -- it will give you an error
             * 
             * following is an another ways to access the remaining values
             */
            Days d2 = (Days)1;
            Console.WriteLine(d2);

            // how to get an integer representation of days
            Days d1  = Days.Monday; 
            Console.WriteLine((int)d1);

            // Get all values of enum by using ForEach Loop

            //it will return names of days
            foreach(string s in Enum.GetNames(typeof(Days))) 
            {
                Console.WriteLine(s);
            }

            //it will return int representation of days
            foreach(int i in Enum.GetValues(typeof(Days)))
            {
                Console.WriteLine(i);
            }

            //method call
            Console.WriteLine(MeetingDate);
            Console.ReadLine();
        }
    }
}
