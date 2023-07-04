using System;
using Tutorial_2.CallStack;

//Explain Call Stack
namespace Tutorial_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start Method: Main");
            Methods.Method1();
            Console.WriteLine("Finish Method: Main");
        }
           
        

    }
}
