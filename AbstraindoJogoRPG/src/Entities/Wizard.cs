using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace abstraindoJogoRPG.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string name, int level, int health) : base(name, level, health)
        {
            this.name = name;
            this.level = level;
            this. health = health;
        }

        public override string Attack()
        {
            return this.name + " Lançou magia!";
        }
    }
}