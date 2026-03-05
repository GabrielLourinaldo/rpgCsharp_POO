using System;

namespace abstraindoJogoRPG
{
    public class Program
    {
        public static void Main()
        {
            Hero hero = new Hero("Gabriel",1,10);
            Hero opponent = new Hero("Ninfus", 10, 40);
            Console.WriteLine(hero);
            Console.WriteLine(hero.Attack());
            Console.WriteLine(opponent);
            
        }
    }
}