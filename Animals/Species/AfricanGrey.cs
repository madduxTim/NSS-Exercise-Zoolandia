namespace Zoolandia.Animals 
{
    public class AfricanGrey : Psittacus 
    {
        public AfricanGrey(string name) : base(name)
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