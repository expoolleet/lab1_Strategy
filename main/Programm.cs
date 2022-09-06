using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Console.WriteLine("\n");

            Rubber rubber = new Rubber();
            rubber.Quak();
            rubber.Swim();
            rubber.Fly();
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
