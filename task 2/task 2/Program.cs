using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    internal class Program
    {
        static void Main(string[] args) { 
            string name ;
            int age;
            double grade;
            double average;
            string gender;

            Console.WriteLine("please enter your name ");
            name= Console.ReadLine();
            Console.WriteLine("please enter your age ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter your grade ");
            grade = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("please enter your average ");
            average = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("please enter your gender ");
            gender = Console.ReadLine();


            Console.WriteLine("===== Student Report ===== ");   
            Console.WriteLine($"Welcome {name}!");
            Console.WriteLine($"name : {name}");
            Console.WriteLine($"age : {age}");
            Console.WriteLine($"grade : {grade}");
            Console.WriteLine($"average : {average}");
            Console.WriteLine($"gender : {gender}\n");


            Console.WriteLine("===== Name Information ===== ");
            Console.WriteLine($"original name : {name}!");
            Console.WriteLine($"uppercase : {name.ToUpper()}");
            Console.WriteLine($"lowercase : {name.ToLower()}");
            Console.WriteLine($"first character : {name[0]}\n");


            Console.WriteLine($"original average : {average}");
            Console.WriteLine($"Bonus Marks : 5 ");
            Console.WriteLine($"New Average : {average+5}\n");


            if (grade >= 50)
            {
                Console.WriteLine("Result: Passed");
            }
            else
            {
                Console.WriteLine("Result: Failed");
            }

            if (age >= 18)
            {
                Console.WriteLine("Adult: True");
            }
            else
            {
                Console.WriteLine("Adult: false");
            }


            Console.WriteLine();
            Console.WriteLine("================================");
            Console.WriteLine("        STUDENT SUMMARY");
            Console.WriteLine("================================");

            Console.WriteLine($"Welcome {name.ToUpper()}!");
            Console.WriteLine();
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Grade: {grade}");
            Console.WriteLine($"Average: {average}");
            Console.WriteLine($"Gender: {gender}");


        }
        }
    
}
