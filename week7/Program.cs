using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Division");

            Console.WriteLine("Enter the number");
            string input1 = Console.ReadLine();

            Console.WriteLine("Enter the number");
            string input2 = Console.ReadLine();

            try
            {
                int x1 = int.Parse(input1);
                int x2 = int.Parse(input2);             
                
                if(x1==0 && x2 == 0)
                {
                    throw new CustomException();
                }
                double result = x1 / x2;
                Console.WriteLine(result);

            }

            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("FormatException");
                Console.WriteLine("Wrong Number");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("DivideByZeroException");
            }
            finally
            {
                Console.WriteLine("Mesaj de final");
            }

            Console.ReadKey();
        }
    }
        [Serializable]
        class CustomException : Exception
        {        
        public CustomException() : base() { }
        }
    }
