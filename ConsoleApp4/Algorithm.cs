using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Algorithm
    {
        public static void Algorithm_1()
        {
            //演算法-氣泡
            int[] ary = new int[] { 3, 2, 1, 7, 5, 6, 9 };//7 0~6


            for (int i = 0; i < ary.Length; i++)
            {
                for (int x = 0; x < ary.Length - 1; x++)
                {
                    if (ary[x] > ary[x + 1])
                    {
                        int temp = ary[x + 1];
                        ary[x + 1] = ary[x];
                        ary[x] = temp;

                    }
                }

            }
            foreach (var a in ary)
                Console.WriteLine(a);


        }

    }
}
