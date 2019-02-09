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
            string text = System.IO.File.ReadAllText(@"C:\Users\Пользователь\Desktop\pp\PP2\Week2\task1\text1.txt");
            Console.WriteLine(text);
            char[] arr = text.ToCharArray();
            Array.Reverse(arr);
            string line2 = new string(arr);
            Console.WriteLine(line2);
            if(text == line2)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}