using System;

namespace Zoolandia.Species 
{
    // Bonobo
    public class PanPaniscus : Animal
    {

        public PanPaniscus(string name, bool smart, double weight, int limbs) : base(name, smart, weight, limbs) 
        {
            
        }
        public override string Movement()
        {
            return "Climb and walk!";
        }
    }
}