using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadNumber
{
    class ReadNr
    {
     public static void Numar(int start, int end)
        {
            int count = 1, number;

            do
            {
                Console.Write("Number{0}: ", count);
                number = Int32.Parse(Console.ReadLine());

                if (number >= end || number <= start)
                {
                    Console.WriteLine("Wrong input!");
                    break;
                }
                else
                    start = number;

                count++;
            } while (count < 11);
         }
    }
}
