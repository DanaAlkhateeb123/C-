using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    internal class Student
    {
        public string name;
        public int age;
        public int grade;

        public Student(string n, int a, int g)
        {
            name = n;
            age = a;
            grade = g;
        }

        public void DisplayInfo()
        {
          
            Console.WriteLine($"student name : {name} \nage : {age} \ngrade : {grade} ");
        }


    }
}
