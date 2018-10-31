using System;
using System.Collections.Generic;
using System.Text;
using duckgame.classes;
using duckgame.classes.Implementations;

namespace duck_game.classes
{
    class RedheadDuck : Duck
    {
        FlyBehavior flyBehavior;
        SwimBehavior swimBehavior;
        QuackBehavior quackBehavior;


        public RedheadDuck(FlyBehavior flyBehavior, SwimBehavior swimBehavior,
                    QuackBehavior quackBehavior)
        {
            this.flyBehavior = flyBehavior;
            this.quackBehavior = quackBehavior;
            this.swimBehavior = swimBehavior;
        }

        public string play()
        {
            return this.flyBehavior.getFlyAsString() + " " + this.swimBehavior.getSwimAsString() + " " +
                      this.quackBehavior.getQuackAsString();
        }
    }
}
