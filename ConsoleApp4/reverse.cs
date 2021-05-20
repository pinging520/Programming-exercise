using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class reverse
    {
        static void a()
        {
            string x = "abcde";
            char[] temp = new Char[x.Length];
            for (int i = 0; i < x.Length; i++)
            {
                temp[i] = x[x.Length - i - 1];
            }

            Console.WriteLine(new string(temp));

        }


    }
}
