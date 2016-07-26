using System;

namespace Zoolandia.Species 
{
    // Bottlenose Dolphin
    public class TursiopsTruncatus : Animal
    {
        public int Pod {get;set;}
        public override string Movement()
        {
            return "Can't " + base.Movement() + ", but definitely swim.";
        }
        public override float Speed()
        {
            return 12;
        }
    }
}