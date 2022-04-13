using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SunriseLibrary;

namespace TheLastSunrise
{
    class TesterProgram
    {
        static void Main(string[] args)
        {
            Console.Title = "-=-=- The Last Sunrise -=-=-";
            Console.WriteLine("Enter the survival horror...\n\n");

            Weapon knife = new Weapon(1, 10, "Combat Knife", 10, false);
            Character character = new Character("Leon Kennedy", 70, 8, 100, 100, PlayableCharacter.TheRookie, knife);

            bool exit = false;
            do
            {
                Console.WriteLine("You have entered a new area:");
                Console.WriteLine(NewArea());

                //TODO 2. Create monster(s)

                bool reload = false;
                do
                {
                    Console.WriteLine("\nPlease choose an action:\n" +
                            "A) Attack\n" +
                            "R) Run Away\n" +
                            "C) Character Info\n" +
                            "E) Enemy Info\n" +
                            "X) Exit\n");

                    ConsoleKey userChoice = Console.ReadKey(true).Key;
                    Console.Clear();

                    switch (userChoice)
                    {
                        case ConsoleKey.A:
                            //TODO 3. Handle the combat logic & what happens if the player wins
                            break;
                        case ConsoleKey.R:
                            Console.WriteLine("Run Away!");
                            //TODO 4. Handle the user running away & the monster getting a free attack
                            break;
                        case ConsoleKey.C:
                            Console.WriteLine("Character Info");
                            Console.WriteLine(character);
                            break;
                        case ConsoleKey.E:
                            Console.WriteLine("Enemy Info");
                            //TODO 6. Print out monster info
                            break;
                        case ConsoleKey.X:
                            Console.WriteLine("It's okay to say you're too scared to continue.");
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Input not understood. Please try again.\n");
                            break;

                    }//End Switch

                    //TODO 7. Check the player's life

                } while (!exit && !reload);
            } while (!exit);

            //TODO 8. State the player's score

        }//End Main

        private static string NewArea()
            //Eventually want to add a menu to select each playable area and build
            //specific rooms unique to each area. Possibly add the ability to "beat" an area (defeat x number of enemies + a unique area "boss"
            //Possibly unlock new areas or just have them all available to play.
        {
            string[] rooms =
            {
                "The Baker Family's Guest House",
                "Lisa's Cabin",
                "Downtown Raccoon City",
                "The Regenerator Lab",
                "The Raccoon City Police Station",
                "The Baker Family's Main House",
                "The Los Illuminados Village",
                "The Baker House Basement",
                "House Beneviento",
                "The Spencer Mansion"
            };

            Random randRoom = new Random();
            int indexNbr = randRoom.Next(rooms.Length);
            string room = rooms[indexNbr];
            return room;

        }//End NewRoom
    }//End Class
}//End Namespace
