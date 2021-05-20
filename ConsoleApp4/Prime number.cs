using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Prime_number
    {
        

        public static void Primenumber()
        {
            //找出質數

            int[] x = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 20, 17 };

            for (int i = 0; i < x.Length; i++)
            {
                int con = 0;
                for (int z = 1; z <= x[i]; z++)
                {
                    if (x[i] % z == 0)
                    {
                        con += 1;
                    }
                }

                if (con == 2 | con == 1)
                { Console.WriteLine("Y"); }
                else { Console.WriteLine("N"); }

            }


        }

    }
}
