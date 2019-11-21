using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayBit64 array1 = new ArrayBit64(5u);
            ArrayBit64 array2 = new ArrayBit64(100u);

            Console.WriteLine("Binary number one:");
            Console.WriteLine(array1);
            Console.WriteLine("Binary number two:");
            Console.WriteLine(array2);

            array1[0] = 0;
            array2[0] = 1;

            Console.WriteLine("Binary number one changed:");
            Console.WriteLine(array1);
            Console.WriteLine("Binary number two changed:");
            Console.WriteLine(array2);

            Console.WriteLine("\n array1 == array2?");
            Console.WriteLine(array1 == array2);

            Console.WriteLine("\n array1 is equal to array1?");
            Console.WriteLine(array1.Equals(array1));

            Console.WriteLine("\n array1  !-array2?");
            Console.WriteLine(array1 != array2);

            Console.WriteLine("\nThe bit with index [2] of array1 is:");
            Console.WriteLine(array1[2]);

            Console.WriteLine("\nThe bit with index [2] of array2 is:");
            Console.WriteLine(array2[2]);
            Console.ReadLine();
        }
       
    }
}
