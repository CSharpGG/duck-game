using System;
using System.Collections.Generic;
using System.Text;

namespace duck_game.classes
{
    class Duck
    {
        public string quack() {
            return "I am a quacking";
        }

        public string swim()
        {
            return "I am swimming";
        }

        public virtual string display()
        {
            return "I am visible original Duck";
        }

        public string fly()
        {
            return "I am flying";
        }
    }
}
