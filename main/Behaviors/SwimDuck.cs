using System;

namespace main.Behaviors
{
    internal class SwimDuck : ISwim
    {
        public void Swim() => Console.WriteLine("Утка плавает");
    }
}
