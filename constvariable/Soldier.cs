using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constvariable
{
    class Soldier : Person
    {
        public const string SJob = "Soldier";
        public const int Rank = 2;
        public Dictionary<int, string> Ammo { get; set; }
        public Soldier(string Id, string Name, string Job) : base(Id, Name, Job)
        {
        }
        public override void Talk()
        {
            Console.WriteLine("{0} says, 'Hello there I am a person and a soldier.'", Name);
        }

    }
}
