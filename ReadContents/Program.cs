using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace ReadContents
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the full path of the file you want to read: ");
            string filePath = File.ReadAllText(@"C:\Windows\win.ini");

            try
            {
                Console.WriteLine(File.ReadAllText(filePath));
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file '{0}' was not found!", filePath);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("The entered file path is not correct!");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("The chosen file is not supported!");
            }
            catch (SecurityException)
            {
                Console.WriteLine("You don't have permission to access this file.");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("The specified path is invalid.");
            }
            catch (IOException)
            {
                Console.WriteLine("An I/O error occurred while opening the file.");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Do not have the permission.");
            }
        }
    }
}

   

