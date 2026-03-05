using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace abstraindoJogoRPG.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string name, int level, int health) : base(name, level, health)
        {
            this.name = name;
            this.level = level;
            this. health = health;
        }

        
    }
}