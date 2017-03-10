using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    public class Rouge : Character
    {
        public Rouge()
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
        public Rouge(int Strength, int Dexterity, int Constitution, int Intelligence, int Wisdom, int Charisma)
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
