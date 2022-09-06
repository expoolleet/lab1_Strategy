using System;

namespace main
{
    class DuckCantSwim : ISwim
    {
        public void Swim() => Console.WriteLine("Утка не умеет плавать");
    }
}
