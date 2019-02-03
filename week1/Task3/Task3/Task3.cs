using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Task3
    {
        static void Main(string[] args)
        {
            string d = Console.ReadLine();// enter string d
            int a = int.Parse(d);// changes string to integer
            string s = Console.ReadLine();// enter string s
            string[] arr = s.Split();// creating array from string
            for (int i = 0; i < a; i++)// cycle run            
                {
                for (int j = 0; j < 2; j++)// cycle 2 times run
                {
                    Console.Write(arr[i] + " ");// cout 2 same integers
                }
            }
            Console.WriteLine();
        }

    }
}