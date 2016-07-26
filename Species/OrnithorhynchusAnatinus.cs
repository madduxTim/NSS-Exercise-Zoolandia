using System;

namespace Zoolandia.Species 
{
    // Platypus
    public class OrnithorhynchusAnatinus : Animal
    {
        public OrnithorhynchusAnatinus(string name, bool smart, double weight, int limbs) : base(name, smart, weight, limbs) 
        {
            
        }
        public override string Movement()
        {
            return base.Movement() + " and waddle";
        }
    }
}