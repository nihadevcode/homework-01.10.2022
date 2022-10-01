using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1 = "n";
            int x = 2;
            int y = 3;
            int z = 5;
            int c = 7;

            int n = 123;

            if (n % x == 0 || n % y == 0 || n % z == 0 || n % c == 0)
            {
                Console.WriteLine("Mürəkkəb ədəddir");
            }
            else
            {
                Console.WriteLine("Sadə ədəddir");
            }
        }

                
        }
    }
}
