using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iterate
{
    class Program
    {
        static void Main()
        {
            
            //Exercise 1
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            Console.WriteLine("Type a color:");
            string colorInput = Console.ReadLine();
            colorInput = textInfo.ToLower(colorInput);
            colorInput = textInfo.ToTitleCase(colorInput);
            string[] Colors = new string[] { "Red ", "Blue ", "Green ", "Yellow ", "Black " };
            for (int i = 0; i < Colors.Length; i++)
            {
                Colors[i] = (Colors[i] + colorInput);
                Console.WriteLine(Colors[i]);
            }
            Console.ReadLine();
            /*Exercise 2           
            while (1 != 0)
            {
                Console.WriteLine(i);
            } 
            */
            // Exercise 3
            Console.WriteLine("Exercise 3");
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(i);
            }
            // Exercise 4
            Console.WriteLine("Exercise 4");
            for (int i = 0;i < 10;i++)
            {
                Console.WriteLine(i);
            }
            // Exercise 5
            Console.WriteLine("Exercise 5");
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            //exercise 6
            List<string> Names = new List<string> { "Paul", "Brent", "Brandon", "Caroline", "Andy" };
            int results = 0;
            Console.WriteLine("Enter a name to search for:");
            string nameSearch = Console.ReadLine();
            nameSearch = textInfo.ToLower(nameSearch);
            nameSearch = textInfo.ToTitleCase(nameSearch);
            for (int i = 0;i < Names.Count; i++)
            {
                if (nameSearch == Names[i])
                {
                    Console.WriteLine(Names[i] + " found!");
                    // exercise 8
                    i = Names.Count;
                    results = 1;
                }

            }
            // exercise 7
            if (results != 1)
            {
                Console.WriteLine("No results.");
            }
            // exercise 9
            List<string> Menu = new List<string> {"Beer", "Beer", "Beer", "Wine", "Whisky", "Water"};
            Console.WriteLine("Search for a menu item:");
            string menuSearch = Console.ReadLine();
            menuSearch = textInfo.ToLower(menuSearch);
            menuSearch = textInfo.ToTitleCase(menuSearch);
            int menuResults = 0;
            for (int i = 0;i < Menu.Count;i++)
            {
                if (menuSearch == Menu[i])
                {
                    Console.WriteLine(i + ":" + Menu[i]);
                    menuResults = 1;
                }
            }
            if (menuResults == 0)
            {
                Console.WriteLine("No results.");
            }
            // Exercise 11
            Console.ReadLine();
            Console.WriteLine("Exercise 11");
            List<string> Menu2 = new List<string> { "Beer", "Beer", "Beer", "Wine", "Whisky", "Water", "Water", "Water" };
            List<string> showMenu = new List<string>();
    

            foreach (string menuItem in Menu2)
            {

                    if (showMenu.Contains(menuItem))
                    {
                        showMenu.Add(menuItem + " Appeared already");
                    }
                    else
                    {
                        showMenu.Add(menuItem);
                    }
                
             }
            foreach (string menuItem2 in showMenu)
            {
                Console.WriteLine(menuItem2);
            }
   
                

            
                
            
            Console.ReadLine();
        }
    }
}
