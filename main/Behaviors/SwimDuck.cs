using System;
using main.Interfaces;

namespace main.Behaviors
{
    internal class SwimDuck : ISwim
    {
        public void Swim() => Console.WriteLine("Утка плавает");
    }
}
