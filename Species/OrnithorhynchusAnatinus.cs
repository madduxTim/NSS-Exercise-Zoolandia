using System;

namespace Zoolandia.Species 
{
    // Platypus
    public class OrnithorhynchusAnatinus : Animal
    {
        public OrnithorhynchusAnatinus(string name) : base(name)
        {
            this.Name = name;
        }
        public override string Movement()
        {
            return base.Movement() + " and waddle";
        }
    }
}