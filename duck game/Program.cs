using System;
using System.Collections.Generic;
using duck_game.classes;
using duckgame.classes;
using duckgame.classes.Implementations;

namespace duck_game
{
    class Program
    {
        static void Main(string[] args)
        {

            Duck duck = new Duck(
                new NormalFlyBehavior(), 
                new NormalSwimBehavior(),
                new NormalQuackBehavior());


            Duck muteDuck = new Duck(
                new NoFlyBehavior(),
                new NormalSwimBehavior(),
                new NormalQuackBehavior());

            List<Duck> ducks = new List<Duck>() { duck, muteDuck };

            foreach(Duck newDuck in ducks){
                Console.WriteLine(newDuck.play());
            }

            Console.ReadLine();


        }
    }
}
