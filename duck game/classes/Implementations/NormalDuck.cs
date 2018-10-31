using System;
using System.Collections.Generic;
using System.Text;
using duckgame.classes;
using duckgame.classes.Implementations;

namespace duck_game.classes
{
    
    public class NormalDuck : Duck, FlyBehavior, SwimBehavior, QuackBehavior
    {
    
    	public FlyBehavior flyBehavior;
        public SwimBehavior swimBehavior;
        public QuackBehavior quackBehavior;

		public NormalDuck()
        {
        	this.flyBehavior = this;
        	this.swimBehavior = this;
        	this.quackBehavior = this;
        }

		public NormalDuck(FlyBehavior flyBehavior, SwimBehavior swimBehavior, QuackBehavior quackBehavior)
        {
        	this.flyBehavior = thiflyBehaviors;
        	this.swimBehavior = swimBehavior;
        	this.quackBehavior = quackBehavior;
        }

        public string getFlyAsString()
        {
            return "Flying";
        }

        public string getQuackAsString()
        {
            return "Quacking";
        }

        public string getSwimAsString()
        {
            return "Swimming";
        }

         public string play()
        {
            return 	this.flyBehavior.getFlyAsString() + 
            		this.swimBehavior.getFlyAsString() + 
            		this.quackBehavior.getFlyAsString();
        }
    }
}
