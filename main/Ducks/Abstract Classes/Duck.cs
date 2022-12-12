using System;
using main.Behaviors;

namespace main.Ducks.Abstract_Classes
{
    internal abstract class Duck 
    {
        public string Name { get; }

        private IFly fly;
        
        private ISwim swim;
        
        private IQuak quak;
        
        private IDie die;

        public Duck(string name, IQuak quak, IFly fly, ISwim swim, IDie die = null)
        {
            Name = name;
            this.fly = fly;
            this.swim = swim;
            this.quak = quak;
            this.die = die ?? new DuckDie();
        }

        public void Fly() => fly.Fly();

        public void Swim() => swim.Swim();

        public void Quak() => quak.Quak();

        public void Die() => die.Die();
    }
}
