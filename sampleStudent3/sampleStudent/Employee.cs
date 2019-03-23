using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sampleStudent
{
    class Employee : Person, IQuittable
    {
        public int Id { get; set; }
        public override void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
            Console.ReadLine();
        }
        public void Quit()
        {
            Console.WriteLine(FirstName + " " + LastName + " has quit.");
            Console.ReadLine();
        }
        public static bool operator== (Employee employee, Employee employee2)
        {
            bool results;
            if (employee.Id == employee2.Id)
            {
                results = true;
                return results;
            }
            else
            {
                results = false;
                return results;
            }

        }
        public static bool operator!= (Employee employee, Employee employee2)
        {
            bool results;
            if (employee.Id != employee2.Id)
            {
                results = true;
                return results;
            }
            else
            {
                results = false;
                return results;
            }
        }
    }
}
