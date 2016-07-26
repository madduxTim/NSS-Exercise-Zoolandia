using System;

namespace Zoolandia.Species 
{
    // Platypus
    public class OrnithorhynchusAnatinus : Animal
    {
        // this.CommonName = "Platypus"; WHY THIS NO WORKY? 
        //
        public int Paddle {get;set;}
        public override string Movement()
        {
            return "Can't really " + base.Movement() + ". More like a waddle...";
        }
        public override float Speed()
        {
            return 2.002f;
        }
    }
}