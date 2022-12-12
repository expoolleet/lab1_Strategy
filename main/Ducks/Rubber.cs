using System;
using main.Ducks.AbstractClasses;
using main.Behaviors;

namespace main.Ducks
{
    internal class Rubber : Duck
    {
        public Rubber() : base("Резиновая утка", new DuckCantQuak(), new DuckCantFly(), new SwimDuck(), new DuckCantDie()) { }
    }
}
