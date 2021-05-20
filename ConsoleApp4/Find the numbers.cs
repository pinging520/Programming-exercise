using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Find_the_numbers
    {
        static void third()
        {
            int[] ary = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            int c = 0;
            int b = 0;
            int a = 0;

            for (int i = 0; i < ary.Length; i++)
            {
                if (a < ary[i])
                {
                    c = b;
                    b = a;
                    a = ary[i];
                }
                else
                {
                    if (ary[i] > b)
                    {
                        c = b;
                        b = ary[i];
                    }
                    else
                    {
                        if (ary[i] > c)
                            c = ary[i];
                    }
                }
            }
            Console.WriteLine(c);

        }



    }
}
