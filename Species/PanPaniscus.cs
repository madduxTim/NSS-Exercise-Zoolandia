using System;

namespace Zoolandia.Species 
{
    // Bonobo
    public class PanPaniscus : Animal
    {

        public PanPaniscus(string name) : base(name)
        {
            this.Name = name;
        }
        public override string Movement()
        {
            return "Climb and walk!";
        }
    }
}