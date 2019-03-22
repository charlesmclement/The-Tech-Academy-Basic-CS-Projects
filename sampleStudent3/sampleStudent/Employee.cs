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
        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
            Console.ReadLine();
        }
        public void Quit()
        {
            Console.WriteLine(FirstName + " " + LastName + " has quit.");
            Console.ReadLine();
        }
    }
}
