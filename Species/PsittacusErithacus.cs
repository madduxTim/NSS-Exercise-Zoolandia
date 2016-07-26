using System;

namespace Zoolandia.Species 
{
    // African Grey 
    public class PsittacusErithacus : Animal 
    {
        public int Company {get;set;}
        public override string Movement()
        {
            return "Can definitely " + base.Movement() + " but probably spends more time flying probably. So would I." ;
        }
        public override float Speed()
        {
            return 4;
        }
    }
}