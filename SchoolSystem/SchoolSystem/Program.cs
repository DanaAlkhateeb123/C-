using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Name = "Sami Ali";
            int Age = 20;
            int Grade = 12;
            double Average = 85.5;
            string Gender = "M";
            bool IsActive = true;

            Console.WriteLine("name : " + Name);
            Console.WriteLine("age : " + Age);
            Console.WriteLine("grade : " + Grade);
            Console.WriteLine("average : " + Average);
            Console.WriteLine("gender : " + Gender);
            Console.WriteLine("active : " + IsActive);

            string[] students = { "dana", "sara", "amal", "saja", "deyaa" };
            Console.WriteLine("Student 1: " + students[0]);
            Console.WriteLine("Student 2: " + students[1]);
            Console.WriteLine("Student 3: " + students[2]);
            Console.WriteLine("Student 4: " + students[3]);
            Console.WriteLine("number of students : " + students.Length);

            Console.WriteLine("the first Student : " + students[0]);
            Console.WriteLine("the last Student : " + students[3]);
            students[2] = "nada";

            Console.WriteLine("Student 1: " + students[0]);
            Console.WriteLine("Student 2: " + students[1]);
            Console.WriteLine("Student 3: " + students[2]);
            Console.WriteLine("Student 4: " + students[3]);
        }
    }
}
