using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_5
{
    internal class Teacher : Person
    {
        public string Subject;
        public Teacher( string n, int a, string subject) : base(n,a)
        {
            Subject = subject;
        }
    }
}
