namespace Zoolandia.Animals 
{
    public class AfricanGrey : Animal 
    {
        public string ScienceName {get;set;}
        public string CommonName {get;set;}
        public AfricanGrey(bool smart, int limbs) : base(smart, limbs)
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