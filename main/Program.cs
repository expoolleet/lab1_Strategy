using System;
using main.Ducks;

namespace main
{
    static public class Program
    {
        static void Main()
        {
            Wild wild = new Wild();
            wild.Quak();
            wild.Swim();
            wild.Fly();
            wild.Die();
            Console.WriteLine("\n");

            Rubber rubber = new Rubber();
            rubber.Quak();
            rubber.Swim();
            rubber.Fly();
            rubber.Die();
            Console.WriteLine("\n");

            Metal metal = new Metal();
            metal.Quak();
            metal.Swim();
            metal.Fly();
            metal.Die();
            Console.WriteLine("\n");

            Console.ReadKey();
        }
    }
}
