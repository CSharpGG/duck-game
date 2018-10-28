using System;
namespace duckgame.classes.Implementations
{
    public class NoFlyBehavior : FlyBehavior
    {
        public NoFlyBehavior()
        {
        }

        public string getFlyAsString()
        {
            return "I cant't fly";
        }
    }
}
