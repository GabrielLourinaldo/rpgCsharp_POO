namespace abstraindoJogoRPG
{
    public abstract class Hero
    {
        public string name;
        public int level;
        public int health;

        public Hero(string name, int level, int health)
        {
            this.name = name;
            this.level = level;
            this. health = health;
        }

        public override string ToString()
        {
            return this.name + " " + this.level + " " + this.health;
        }

        public virtual string Attack()
        {
            return this.name + "Atacou com espada!";
        }
    }
}