using System;
// Structure in CSharp
/*
 * 1. User Defined Data Type
 * 2. Syntax is same as that of class.
 * 3. Used for smaller data entities.
 * 4. Creating obejects with new keyword is optional 
 * 5. if you create 0 constructors in structure then after compilation their will be 1 constructor (implicit)
 *    and if you define "n" costructors in it then after compilation their will be n+1 constructors.
 *    Because you can not explicitly define parameterless constructor if you did you will get an error
 *    
 */
struct MyStruct
{
    //int i = 10;  -- you can not initialized field at the time of decalration
    int i;

    //parameterised constructor
    public MyStruct(int i)
    {
        this.i = i;
    }

    public void Display()
    {
        Console.WriteLine("Display method of a structor" + i);
    }

    static void Main(string[] args)
    {
        //Follwing are differernt ways to initialize the instance variable i

        //1. by using default constructor 
        MyStruct M = new MyStruct();
        M.Display();

        //2. by not using new keyword 
        MyStruct M1;
        M1.i = 10;
        M1.Display();

        //3. by using parameterised constructor
        MyStruct M3 = new MyStruct(11);
        M3.Display();

        Console.ReadLine();
    }
}