using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Task1
    {
        static void Main(string[] args)
        {
            string g = Console.ReadLine();
            int a = int.Parse(g); // creating integer from string

            string l = Console.ReadLine();
            string[] arr = l.Split();// creating array from string
            for (int i = 0; i < a; i++)// started cycle
            {
                float b = int.Parse(arr[i]);// changes integers in array to float
                for (int j = 2; j <= Math.Sqrt(b); j++)// loop to check if the particular number has divisors
                {
                    if (b % j == 0 && b != j)
                    {
                        b = 0;
                        break;
                    }
                }
                if (b != 0 && b != 1)
                {
                    Console.Write(b + " ");// outputting the elements with space
                }

            }

            Console.WriteLine();
        }
    }
}