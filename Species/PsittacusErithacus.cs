namespace Zoolandia.Species 
{
    // African Grey 
    public class PsittacusErithacus : Animal 
    {
        public string ScienceName {get;set;}
        public string CommonName {get;set;}
        public PsittacusErithacus()
        {
            this.ScienceName = "Psittacus Erithacus";
            this.CommonName = "African Grey"; 
        }
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