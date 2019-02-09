using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string di = (@"C:\Users\Пользователь\Desktop\pp\PP2\Week2\Task4\Ex1\");
            string Ex2 = (@"C:\Users\Пользователь\Desktop\pp\PP2\Week2\Task4\Ex2");
            string Ex1 = (@"C:\Users\Пользователь\Desktop\pp\PP2\Week2\Task4\Ex1");
            string nameoft = Console.ReadLine();
            string s = Path.Combine(Ex1, nameoft + ".txt");
            string d = Path.Combine(Ex2, nameoft + ".txt");
            StreamWriter sw = File.CreateText(s);
            sw.Close();
            File.Copy(s, d, true);
            File.Delete(di + nameoft + ".txt");
        }
    }
}