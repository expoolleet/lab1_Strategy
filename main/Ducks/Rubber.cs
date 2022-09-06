using System;

namespace main
{
    class Rubber : Duck
    {
        public Rubber() : base("Резиновая утка", new DuckCantQuak(), new DuckCantFly(), new SwimDuck(), new DuckCantDie()) { }

    }
}
