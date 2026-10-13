using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_5
{
    internal class Student : Person
    {
    public int Grade {  get; set; }
    public int StudentId { get; set; }
        public Student(string name, int age, int grade, int studentId): base( name, age)
        {
            Grade = grade;
            StudentId = studentId;
        }
        
    }
}
