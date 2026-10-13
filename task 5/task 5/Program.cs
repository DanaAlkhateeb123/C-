using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("dana", 23);
            //p.SchoolName;
            //p._internalCode;
            Student student1 = new Student("sara", 22, 80, 1);
            Student student2 = new Student("omar", 23, 90, 2);
            student1.DisplayInfo();
            student2.DisplayInfo();
            Teacher t = new Teacher("ahmad",43,"math");
            SchoolReport s = new SchoolReport(" c sharp ");
            s.DisplayReportTitle();


        }
    }
}
