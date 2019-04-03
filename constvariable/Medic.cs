﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace constvariable
{
    class Medic : Person
    {
        public const string Job = "Medic";
        public const int Rank = 2;

        public Medic(string Id, string Name, string Job) : base(Id, Name, Job)
        {
        }
        public override void Talk()
        {
            Console.WriteLine("{0} the {1} says, 'Hello, may I offer you some pills?'", Name, Job);
        }
    }
}
