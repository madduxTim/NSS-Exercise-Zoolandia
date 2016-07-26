using System;

namespace Zoolandia.Species 
{
    // Bottlenose Dolphin
    public class TursiopsTruncatus : Animal
    {

        public TursiopsTruncatus(string name) : base(name)
        {
            this.Name = name;
        }
        public override string Movement()
        {
            return "Swim!";
        }

    }
}