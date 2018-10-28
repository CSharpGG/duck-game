using System;
using duck_game.classes;
using duckgame.classes.Implementations;

namespace duck_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck mallardDuck = new MallardDuck();
            mallardDuck.flyBehavior = new NormalFlyBehavior();
            mallardDuck.quackBehavior = new NormalQuackBehavior();
            mallardDuck.swimBehavior = new NormalSwimBehavior();


            Duck redHeadDuck = new RedheadDuck();
            redHeadDuck.flyBehavior = new NoFlyBehavior();
            redHeadDuck.quackBehavior = new NormalQuackBehavior();
            redHeadDuck.swimBehavior = new NormalSwimBehavior();


            Console.WriteLine(mallardDuck.flyBehavior.getFlyAsString());
            Console.WriteLine(mallardDuck.quackBehavior.getQuackAsString());
            Console.WriteLine(mallardDuck.swimBehavior.getSwimAsString());

            Console.WriteLine(" ");

            Console.WriteLine(redHeadDuck.flyBehavior.getFlyAsString());
            Console.WriteLine(redHeadDuck.quackBehavior.getQuackAsString());
            Console.WriteLine(redHeadDuck.swimBehavior.getSwimAsString());
            Console.ReadLine();




        }
    }
}
