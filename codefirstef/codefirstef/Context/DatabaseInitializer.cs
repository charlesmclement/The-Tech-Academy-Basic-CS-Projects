using codefirst.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace codefirst.Context
{
    public class DatabaseInitializer : DropCreateDatabaseIfModelChanges<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            var characters = new List<Character>()
            {
                new Character {name="Gul", age=45, gender=Gender.Male, height=66, weight=130, race=Race.Human, job=Job.Cleric,
                    sdesc ="The short, long-braided man", mdesc="You see a man of short stature with black hair braided into a long braid."},
                new Character { name="Aray", age=31, gender=Gender.Male, height=74, weight=200, race=Race.Human, job=Job.Warrior,
                    sdesc ="The blond, blue-eyed man", mdesc="A strong looking man with bright hair and eyes. His skin is tanned from long hours under the sun." },
                new Character { name="Meli", age=55, gender=Gender.Female, height=62, weight=100, race=Race.Elf, job=Job.Mage,
                    sdesc ="The wrinkled, elven woman", mdesc="Time under the sun has been unkind to this woman, her skin is worn and leathery."},
                new Character { name="Falcon", age=30, gender=Gender.Male, height=78, weight=190, race=Race.HalfElf, job=Job.Ranger,
                    sdesc ="The muscle-bound half-breed", mdesc="Sharply pointed ears and almond shaped eyes hint at this mostly human man's elven heritage."}
            };

            characters.ForEach(x => context.Characters.Add(x));
            context.SaveChanges();
        }
    }
}