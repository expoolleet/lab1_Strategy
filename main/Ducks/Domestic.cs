using System;

namespace main
{
    class Domestic : Duck
    {
        public Domestic() : base("Домашняя утка", new QuakDuck(), new DuckCantFly(), new SwimDuck(), new DuckDie()) { }

    }
}
