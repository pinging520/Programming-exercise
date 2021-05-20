using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class triangle
    {

        public static void triangles()
        {
            //倒三角型
            int c = 0;
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 1; (i < 4 ? j <= 7 % (i + 3) : j <= i % 4); j++)
                {
                    Console.Write(" ");
                }
                for (int x = 1; (i <= 4 ? x <= (i + 7) % 7 : x <= 8 % i); x++)
                {
                    if (i <= 4) { c = (i + 7) % 7; } else { c = 8 % i; }
                    if (x == 1 | x == c) { Console.Write("*"); } else { Console.Write("-"); }

                }

                Console.WriteLine("");
            }

            //正三角形
            for (int i = 1; i <= 10; i++)
            {
                for (int x = 1; (i <= 5 ? x <= i : x <= 10 % i); x++)
                { Console.Write("*"); }
                Console.WriteLine("");
            }





        }



    }
}
