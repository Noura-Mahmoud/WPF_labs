using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emloyeeList
{
    public class Employee
    {
        public int Id { get; set; }
        public int Salary { get; set; }
        public String Name { get; set; }
        public String Image { get; set; }
        public float Grade { get; set; }

        public override string ToString()
        {
            return $"Name:{Name}";
        }
    }
}
