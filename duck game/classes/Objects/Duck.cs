using System;
using System.Collections.Generic;
using System.Text;
using duckgame.classes;

namespace duck_game.classes
{
    public class Duck
    {
        FlyBehavior flyBehavior;
        SwimBehavior swimBehavior;
        QuackBehavior quackBehavior;


        public Duck(FlyBehavior flyBehavior, SwimBehavior swimBehavior,
                    QuackBehavior quackBehavior)
        {
            this.flyBehavior = flyBehavior;
            this.quackBehavior = quackBehavior;
            this.swimBehavior = swimBehavior;
        }

        public String play(){
            return this.flyBehavior.getFlyAsString()+ " " + this.swimBehavior.getSwimAsString() +" " +
                       this.quackBehavior.getQuackAsString();
        }


    }
}
