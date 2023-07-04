using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorial_2.CallStack
{
    public class Methods
    {
        public static void Method1()
        {
            Console.WriteLine("Start Method: Method 1");
            Method2();
            Console.WriteLine("Finish Method: Method 1");

        }

        public static void Method2()
        {
            Console.WriteLine("Start Method: Method 2");
            Method3();
            Console.WriteLine("Finish Method: Method 2");

        }

        public static void Method3()
        {
            Console.WriteLine("Start Method: Method 3");
        }
    }
}
