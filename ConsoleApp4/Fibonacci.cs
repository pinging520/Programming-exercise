using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Fibonacci 
    {

        public static void Fi()
        { 
            //費氏數列
            int a = 0, b = 1, c;
            for (int i = 0; i <= 10; i++)
            {
                c = a;
                a += b;
                b = c;
                Console.WriteLine(a);
            }    


        }   
    }
}
