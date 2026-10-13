using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_5
{
    internal class Person
    {
        public string Name;
        public int Age {  get; set; }
        protected string SchoolName;
        private string _internalCode;// cant be accessed outside person class because its a private field 

        public Person(string name,int age)
        {
            Name = name;
            Age = age;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"name : {Name} , age : {Age}");
        }


    }
     sealed class SchoolReport
    {
      public string ReportTitle { get; set; }
        public void DisplayReportTitle() { Console.WriteLine($"report title : {ReportTitle}"); }
      public SchoolReport(string RT)
        {
            ReportTitle = RT;
        }        


    }
}
