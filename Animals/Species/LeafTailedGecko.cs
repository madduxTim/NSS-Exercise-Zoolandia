namespace Zoolandia.Animals 
{
    public class LeafTailedGecko : Uroplatus 
    {
        public LeafTailedGecko(string name) : base(name)
        {
            this.ScienceName = "Uroplatus henkeli";
            this.CommonName = "Leaf-tailed Gecko"; 
        }
        public int Company {get;set;}
        public override string Movement()
        {
            return "Shimmies." ;
        }
        public override float Speed()
        {
            return 4;
        }
    }
}