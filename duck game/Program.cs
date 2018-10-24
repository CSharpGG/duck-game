using System;
using duck_game.classes;

namespace duck_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck duck = new Duck();
            Duck mallarDuck = new MallardDuck();
            Duck redheadDuck = new RedheadDuck();
            Console.WriteLine(duck.display());
            Console.WriteLine(mallarDuck.display());
            Console.WriteLine(redheadDuck.display());
            Console.WriteLine("Press any key to close.");
            Console.ReadKey();
        }
    }
}
