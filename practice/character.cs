using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    public abstract class Character
    {

        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }


        public double height {get;set;}
        public double weight {get;set;}
        public string name {get;set;}
        public int age {get;set;}
        public string gender {get;set;}
      
    }
}
