
using System;

namespace main
{
    abstract class Duck 
    {
        public string Name { get; }

        public IFly fly;

        public ISwim swim;

        public IQuak quak;

        public IDie die;


        public Duck(string name, IQuak quak, IFly fly, ISwim swim, IDie die = null)
        {
            Name = name;
            this.fly = fly;
            this.swim = swim;
            this.quak = quak;
            this.die = die?? new DuckDie();
        }


        public void Fly() => fly.Fly();

        public void Swim() => swim.Swim();

        public void Quak() => quak.Quak();

        public void Die() => die.Die();

    }
}
