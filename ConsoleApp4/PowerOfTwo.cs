using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class PowerOfTwo
    {

        static void a()
        {
            int x = int.Parse(Console.ReadLine());
            int a = 1;
            int c = 2;
            while (c < x)
            {
                c *= 2;
                a++;
            }

            if (c == x)
            {
                Console.WriteLine(a);
            }
            else
            {
                if (x == 1)
                { Console.WriteLine("0"); }
                else
                {
                    Console.WriteLine("-1");
                }
            }

        }



    }
}
