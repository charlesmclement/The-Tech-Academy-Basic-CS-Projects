using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace constvariable
{
    class Medic : Person
    {
        public const string Job = "Medic";

        public Medic(string Id, string Name, string Job) : base(Id, Name, Job)
        {
        }
        public override void Talk()
        {
            Console.WriteLine("{0} says, 'Hello there I am a person and a medic.'", Name);
        }
    }
}
