using System;

namespace Zoolandia.Species 
{
    // African Grey 
    public class PsittacusErithacus : Animal 
    {

        public PsittacusErithacus(string name) : base(name)
        {
            this.Name = name;
        }
        public override string Movement()
        {
            return "Fly!";
        }
 
    }
}