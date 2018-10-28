using System;
using System.Collections.Generic;
using System.Text;
using duckgame.classes;

namespace duck_game.classes
{
    class Duck
    {
        public QuackBehavior quackBehavior { get; set; }
        public SwimBehavior swimBehavior { get; set; }
        public FlyBehavior flyBehavior { get; set; }

        public virtual String getNameAsString(){
            return "I am a simple Duck";
        }
    }
}
