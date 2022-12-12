using System;
using main.Ducks.AbstractClasses;
using main.Behaviors;

namespace main.Ducks
{
    internal class Metal : Duck
    {
        public Metal() : base("Металлическая утка", new DuckCantQuak(), new DuckCantFly(), new DuckCantSwim(), new DuckCantDie()) { }
    }
}
