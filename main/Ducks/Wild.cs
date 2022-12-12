using System;
using main.Ducks.AbstractClasses;
using main.Behaviors;

namespace main.Ducks
{
    internal class Wild : Duck 
    {
        public Wild () : base("Дикая утка", new QuakDuck(), new FlyDuck(), new SwimDuck(), new DuckDie()) { }
    }
}
