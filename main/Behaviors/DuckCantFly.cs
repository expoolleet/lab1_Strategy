using System;


namespace main
{
    class DuckCantFly : IFly
    {
        public void Fly() => Console.WriteLine("Утка не умеет летать");
    }
}
