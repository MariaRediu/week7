using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace downloadFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter URL of the file: ");
            string url = Console.ReadLine();

            Console.Write("Enter directory: ");
            string directory = Console.ReadLine();

            WebClient webClient = new WebClient();

            try
            {
                webClient.DownloadFile(url, directory);
                Console.WriteLine("Complete download!");
            }
            catch (WebException)
            {
                Console.WriteLine("Empty file ");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("The method has been called simultaneously on multiple threads.");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Invalid address. The address can not be null.");
            }
            finally
            {
                webClient.Dispose();
                Console.WriteLine("\nGoodbye!\n");
                
            }
        }
    }
}
