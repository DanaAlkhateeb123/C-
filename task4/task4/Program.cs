using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("dana" , 23, 90);
            student1.DisplayInfo();

            Student student2 = new Student("sara", 23, 98);
            student2.DisplayInfo();

            Student student3 = new Student("omar", 22, 97);
            student3.DisplayInfo();

        }
    }
}
