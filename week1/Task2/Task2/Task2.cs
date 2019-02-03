using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Student
    {
        public string name;
        public string ID;
        public int year;
        public Student(string name1, string Id, int y1)
        {
            this.name = name1;
            this.ID = Id;
            this.year = y1;
        }
        public void GetInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Id: " + ID);
        }
        public void Plus()
        {
            year++;
            Console.WriteLine("Year: " + year);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string n1 = Console.ReadLine();
            string ID1 = Console.ReadLine();
            int y1 = Convert.ToInt32(Console.ReadLine());
            Student s1 = new Student(n1, ID1, y1);
            s1.GetInfo();
            s1.Plus();


        }
    }
}
