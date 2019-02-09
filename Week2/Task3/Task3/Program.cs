using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task3
{
    class Program
    {
        public static void pub(int time)
        {
            for (int i = 0; i < time; i++)
            {
                Console.Write("   ");
            }
        }
        static void Main(string[] args)
        {
            int a = 0;

            DirectoryInfo di = new DirectoryInfo(@"C:\Users\Пользователь\Desktop\pp");
            foreach (var fi in di.GetFileSystemInfos("*", SearchOption.AllDirectories))
            {
                if (fi.GetType() == typeof(DirectoryInfo))
                {
                    a++;
                    pub(a);
                    Console.WriteLine(fi.Name);
                }
                else if (fi.GetType() == typeof(FileInfo))
                {
                    pub(a + 1);
                    Console.WriteLine("  " + fi.Name);
                }
            }
            Console.WriteLine();
        }
    }
}