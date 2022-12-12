using System;
using main.Ducks.Abstract_Classes;
using main.Behaviors;

namespace main.Ducks
{
    internal class Domestic : Duck
    {
        public Domestic() : base("Домашняя утка", new QuakDuck(), new DuckCantFly(), new SwimDuck(), new DuckDie()) { }
    }
}
