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
        }
        public virtual void Talk()
        {
            Console.WriteLine("{0} says, 'Hello there I am a person.'",Name);
        }
    }
}
