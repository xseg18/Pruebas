using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6.Pokemon
{
    public class Pokemon
    {
        public string Name { get; set; }
        public int Life { get; set; }
        public int Attack { get; set; }
        public int Level { get; set; }

        public Pokemon(string name, int life, int attack, int level) { 
            Name = name;
            Life = life;
            Attack = attack;
            Level = level;
        }
    }
}
