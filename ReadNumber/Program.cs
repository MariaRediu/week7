using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ReadNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Start: ");
            int start = Int32.Parse(Console.ReadLine());
            Console.Write("End: ");
            int end = Int32.Parse(Console.ReadLine());

            int nr = 1;
            try
            {
                if (end <= start + 10)
                {
                    Console.WriteLine("Wrong input");
                }
                else
                {

                   int nr= Numar(start, end);
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("The number is NOT integer!");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Null is NOT integer.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("The number is NOT in the range of integer.");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("The number is NOT in the range.");
            }

            Console.ReadKey();
        }
    }
 }
   