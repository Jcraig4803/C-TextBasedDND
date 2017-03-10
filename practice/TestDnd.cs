using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class TestDnd
    {

        static void Main(string[] args)
        {
            string adminName = "John Craig";
            string adminPassword = "021295";
            string adminCharacterName = "Demonicdemon906";
            string adminCharacterClass = "Warrior";
            string adminCharacterSubClass = "Paladian";
            string adminUserInput = "";
            string adminPasswordInput = "";

            string userInput = "";
            string Admin = "Admin";
            string PasswordInput = "";
            string CharacterName = "";
            string CharacterClass = "";
            string CharacterSubClass  = "";

            Console.WriteLine("If you are Admin type Admin and Log in \n");
            Console.WriteLine("If you are not Admin press enter");
            userInput = Console.ReadLine();

            if (userInput == Admin) {
            
                Console.WriteLine("Input Admin username");
                Console.WriteLine("Input Admin password");
                adminUserInput = Console.ReadLine();
                adminPasswordInput = Console.ReadLine();
            }
            else 
            {
                Console.WriteLine("Input Username");
                userInput = Console.ReadLine();
                Console.WriteLine("Input password");
                PasswordInput = Console.ReadLine();
            }
   
            if (adminUserInput == adminName && adminPasswordInput == adminPassword)
            {
                Console.WriteLine("Admin Character name: " + adminCharacterName +"\n"+ "Admin Character class: " + adminCharacterClass + "\n" + "Admin Character subclass: " + adminCharacterSubClass);
                Console.ReadLine();
            }
            else
            {
               Console.WriteLine("Input Character Name");
               CharacterName = Console.ReadLine();

               Console.WriteLine("Input Character Class");
               CharacterClass = Console.ReadLine();

               Console.WriteLine("Input Character Sub-Class");
               CharacterSubClass = Console.ReadLine();

               Console.WriteLine("Character name: " + CharacterName + "\n" + "Character class: " + CharacterClass + "\n" + "Character subclass: " + CharacterSubClass);
               Console.ReadLine();
            }


            var Warrior = new Warrior();
                Warrior.Strength = 12;
                Warrior.Dexterity = 10;
                Warrior.Constitution = 12;
                Warrior.Intelligence = 8;
                Warrior.Wisdom = 8;
                Warrior.Charisma = 10;

            var Rouge = new Rouge();
                Rouge.Strength = 10;
                Rouge.Dexterity = 12;
                Rouge.Constitution = 10;
                Rouge.Intelligence = 8;
                Rouge.Wisdom = 8;
                Rouge.Charisma = 12;

            var Mage = new Mage();
                Mage.Strength = 8;
                Mage.Dexterity = 8;
                Mage.Constitution = 10;
                Mage.Intelligence = 12;
                Mage.Wisdom = 12;
                Mage.Charisma = 10;

            /* 
                 Strength: 
                 Dexterity:
                 Constitution:
                 Intelligence:
                 Wisdom:
                 Charisma:
             */

        }
    }
}
