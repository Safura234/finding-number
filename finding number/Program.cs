using System;
using System.Linq;

namespace finding_number
{
    internal class Program
    {
        private static object array;
        private static int length;

        static void Main(string[] args)
        {
            Console.WriteLine("Finding number");
            int num = 468;
           while (true)
            { 
                if (num % 10 == 8)
                {
                    int result = num % 10;
                    Console.WriteLine(result);
                    return;
                }
                num = num / 10; 
            }
        
            }
        }
    }

