using System;

namespace Zoolandia.Species 
{
    // Bonobo
    public class PanPaniscus : Animal
    {
        public int Troop {get;set;}

        public override string Movement()
        {
            return "Climb and " + base.Movement(); 
        }
        public override float Speed()
        {
            return 5;
        }
    }
}