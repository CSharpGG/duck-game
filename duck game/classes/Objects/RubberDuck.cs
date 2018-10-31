using System;
using System.Collections.Generic;
using System.Text;
using duckgame.classes;
using duckgame.classes.Implementations;
//yoyo: cual es la diferencia entre los patos, no deberian tener comportamientos predeterminados
namespace duck_game.classes
{
    class RubberDuck : Duck
    {
        FlyBehavior flyBehavior;
        SwimBehavior swimBehavior;
        QuackBehavior quackBehavior;


        public RubberDuck(FlyBehavior flyBehavior, SwimBehavior swimBehavior,
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
