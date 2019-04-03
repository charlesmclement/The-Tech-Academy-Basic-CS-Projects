using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constvariable
{
    class Person
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }

        public Person(string Id, string Name, string Job)
        {
            this.Id = Id;
            this.Name = Name;
            this.Job = Job;
        }
        public virtual void Talk()
        {
            Console.WriteLine("{0} says, 'Hello, what do I do?'", Name);
        }
    }
}
