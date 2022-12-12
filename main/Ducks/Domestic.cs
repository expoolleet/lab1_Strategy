using System;
using main.Ducks.AbstractClasses;
using main.Behaviors;

namespace main.Ducks
{
    internal class Domestic : Duck
    {
        public Domestic() : base("Домашняя утка", new QuakDuck(), new DuckCantFly(), new SwimDuck(), new DuckDie()) { }
    }
}
