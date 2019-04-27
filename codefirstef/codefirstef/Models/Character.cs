using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace codefirst.Models
{
    public class Character
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public int height { get; set; }
        public int weight { get; set; }
        public string sdesc { get; set; }
        public string mdesc { get; set; }
        public Gender gender { get; set; }
        public Job job { get; set; }
        public Race race { get; set; }
    }
    public enum Gender
    {
        Male, Female, Other
    }
    public enum Job
    {
        Warrior, Mage, Cleric, Ranger
    }
    public enum Race
    {
        Human, Elf, Dwarf, HalfElf
    }

}