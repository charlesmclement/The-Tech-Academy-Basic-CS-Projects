using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sampleStudent
{
    class Program
    {
        static void Main(string[] args)
        { 
            Employee sampleStudent = new Employee() { FirstName = "Sample", LastName = "Student" };
            sampleStudent.SayName();
        }
    }
}

