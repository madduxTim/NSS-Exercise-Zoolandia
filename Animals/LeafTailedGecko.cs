namespace Zoolandia.Animals 
{
    public class LeafTailedGecko : Animal 
    {
        public string ScienceName {get;set;}
        public string CommonName {get;set;}
        public LeafTailedGecko(bool smart, int limbs) : base(smart, limbs)
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