namespace Zoolandia.Animals 
{
    public class TibetanSandFox : Vulpes 
    {
        public TibetanSandFox(string name) : base(name)
        {
            this.ScienceName = "Vulpes ferrilata";
            this.CommonName = "Tibetan Sand Fox"; 
        }
        public int Company {get;set;}
        public override string Movement()
        {
            return "Can definitely " + base.Movement() + " and run." ;
        }
        public override float Speed()
        {
            return 4;
        }
    }
}