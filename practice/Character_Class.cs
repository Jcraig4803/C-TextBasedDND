using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    public class Character_Class
    {
        /* Strength: 
           Dexterity:
           Constitution:
           Intelligence:
           Wisdom:
           Charisma:
        */

        // The basic classes (The WARRIOR, The ROUGE, The SORCERER)
        // these three classes will have branched classed
        public ChooseClass()
        {
            // The Warrior will have Two branch classes (Barbarin, and Paladian)
            if ChooseClass = Warrior
                {
                Console.WriteLine("Warrior");
                Console.WriteLine("Please select a type of Warrior." + "\n" + "Barbarin" + "\n" + "Paladian");
                if Warrior = Barbarin
                {
                    Console.WriteLine("Barbarin");
                    // Warrior/Barbarin (focused on strength (+2) and constitution (+2))
                }
                else Warrior = Paladian
                {
                    Console.WriteLine("Paladian");
                    // Warrior/Paladian (focused on strength (+2) and wisdom (+2))
                }
            }
            // The Rouge will have Two branch classes (Ranger, and Thief)
            else Chooseclass = Rouge
            {
                Console.WriteLine("Rouge");
                Console.WriteLine("Please select a type of Rouge." + "\n" + "Ranger" + "\n" + "Thief")
                if Rouge = Ranger
                {
                    Console.WriteLine("Ranger");
                    // Rouge/Ranger (focused on dexterity (+2) and intelligence (+2))
                }
                else Rouge = Thief
                {
                    Console.WriteLine("Thief");
                    // Rouge/Thief  (focused on dexterity (+2) and wisdom (+2))
                }
            }
            // The Mage will have two branch classes (Sorecerer, Preist)
            else Chooseclass = Mage
            {
                Console.WriteLine("Mage");
                Console.WriteLine("Please select a type of Mage." + "\n" + "Sorecerer" + "\n" + "Preist");
                if Mage = Sorecerer
                {
                    Console.WriteLine("Sorecerer");
                    // Mage/Sorecerer (focused on intelligence (+3) and wisdom (+1))
                }
                else Mage = Preist
                {
                    Console.WriteLine("Preist");
                    // Mage/Preist    (focused on intelligence (+1) and wisdom (+3))
                }
            }
        }
    }
}
       
    

