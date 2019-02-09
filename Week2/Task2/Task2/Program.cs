using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {

            string g = System.IO.File.ReadAllText(@"C:\Users\Пользователь\Desktop\pp\PP2\Week2\Task2\ex1.txt");
            string[] arr = g.Split();
            for (int i = 0; i < arr.Length; i++)
            {
                float d = float.Parse(arr[i]);
                for (int j = 2; j <= Math.Sqrt(d); j++)
                {
                    if (d % j == 0)
                    {
                        d = 0;
                        break;
                    }
                }
                if (d != 0 && d != 1)
                {
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\Пользователь\Desktop\pp\PP2\Week2\Task2\ex2.txt", true))
                    {
                        file.Write(d + " ");
                    }
                }

            }
        }
    }
}