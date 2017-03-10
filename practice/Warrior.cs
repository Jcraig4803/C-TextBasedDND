using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    public class Warrior : Character
    {
        public Warrior()
        {
        }
/* 
  Strength: 
  Dexterity:
  Constitution:
  Intelligence:
  Wisdom:
  Charisma:
*/
        public Warrior(int Strength, int Dexterity, int Constitution, int Intelligence, int Wisdom, int Charisma)
        {
            this.Strength = Strength;
            this.Dexterity = Dexterity;
            this.Constitution = Constitution;
            this.Intelligence = Intelligence;
            this.Wisdom = Wisdom;
            this.Charisma = Charisma;
        }
    }
}
