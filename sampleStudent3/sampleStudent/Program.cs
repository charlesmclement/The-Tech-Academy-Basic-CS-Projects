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
            Employee sampleStudent = new Employee() { FirstName = "Sample", LastName = "Student", Id = 0 };
            Employee sampleStudent2 = new Employee() { FirstName = "Sample", LastName = "Student", Id = 0 };
            Console.WriteLine(
                "Comparing " + sampleStudent.FirstName + " " + sampleStudent.LastName + 
                " to " + sampleStudent2.FirstName + " " + sampleStudent2.LastName);
            bool compareStudents = sampleStudent == sampleStudent2;
            if (compareStudents == true)
            {
                Console.WriteLine("Match");
            }
            else
            {
                Console.WriteLine("No Match");
            }
            sampleStudent.Quit();

        }
    }
}

