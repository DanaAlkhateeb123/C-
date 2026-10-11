using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Random random = new Random();
            //int secretNumber = random.Next(50, 76);
            //int counter =1;
            //Console.WriteLine("plz enter a guess");
            //int guess= Convert.ToInt32(Console.ReadLine());
            //while (secretNumber != guess)
            //{
            //    counter++;

            //    if (guess > secretNumber)
            //    {
            //        Console.WriteLine("Try a lower number.");
            //    }
            //    if (guess < secretNumber)
            //    {
            //        Console.WriteLine("Try a higher  number.");
            //    }
            //    guess = Convert.ToInt32(Console.ReadLine());
            //}

            //if (counter == 1)
            //{
            //    Console.WriteLine("you earned 10 points !");
            //}
            //if (counter == 2)
            //{
            //    Console.WriteLine("you earned 7 points !");
            //}
            //if (counter == 3)
            //{
            //    Console.WriteLine("you earned 5 points !");
            //}
            //if (counter > 3)
            //{ 
            //    Console.WriteLine("you earned 0 points !");
            //}

            //Console.WriteLine($"attempts =  {counter}");


            int[] stdgrade = { 85, 92, 68, 75, 90 };
            foreach (int i in stdgrade) { Console.WriteLine($"Student Grade : {i}"); }




            string[] stdarr = { "ahmad", "sara", "omar", "lina", "yazan" };

            int choice;

            do
            {
                Console.WriteLine("===== School System =====");
                Console.WriteLine("1. Display Students");
                Console.WriteLine("2. Search for Student");
                Console.WriteLine("3. Check Student Result");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        {

                            for (int i = 0; i < stdarr.Length; i++)
                            {
                                Console.WriteLine($"student {i + 1} : {stdarr[i]}");
                            }

                        }
                        break;
                    case 2:
                        {

                            Console.WriteLine("plz enter a student name to search about : ");
                            string name = Console.ReadLine();
                            int x = 0;
                            bool isavailable = false;
                            while (x < stdarr.Length)
                            {
                                if (name == stdarr[x])
                                {
                                    isavailable = true;
                                    break;
                                }

                                x++;

                            }
                            if (isavailable == true)
                            {
                                Console.WriteLine("Student Found!");
                            }

                            if (isavailable == false)
                            {
                                Console.WriteLine("Student Not Found.");

                            }
                        }
                            break;
                    case 3:
                        {

                            Console.WriteLine("plz enter your grade : ");
                            int grade = Convert.ToInt32(Console.ReadLine());

                            if (grade >= 90 && grade <= 100)
                            {
                                Console.WriteLine(" Excellent ");
                            }
                            else if (grade >= 80 && grade <= 89)
                            {
                                Console.WriteLine(" Very Good ");
                            }
                            else if (grade >= 70 && grade <= 79)
                            {
                                Console.WriteLine(" Good ");
                            }
                            else if (grade >= 60 && grade <= 69)
                            {
                                Console.WriteLine(" Pass ");
                            }
                            else
                            {
                                Console.WriteLine(" Fail ");
                            }



                        }
                        break;


                    default:
                        Environment.Exit(0);
                        break;

                } 
            }while(true) ;

        }
    }
}