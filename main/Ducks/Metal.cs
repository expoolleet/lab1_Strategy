using System;

namespace main
{
    class Metal : Duck
    {
        public Metal() : base("Металлическая утка", new DuckCantQuak(), new DuckCantFly(), new DuckCantSwim(), new DuckCantDie()) { }

    }
}
