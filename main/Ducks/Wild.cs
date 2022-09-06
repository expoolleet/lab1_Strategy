using System;

namespace main
{
    class Wild : Duck 
    {

        public Wild () : base("Дикая утка", new QuakDuck(), new FlyDuck(), new SwimDuck(), new DuckDie()) { }

    }
}
