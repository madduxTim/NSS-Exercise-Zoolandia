namespace Zoolandia.Species 
{
    public class TibetanSandFox : Animal 
    {
        public string ScienceName {get;set;}
        public string CommonName {get;set;}
        public TibetanSandFox(bool smart, int limbs) : base(smart, limbs)
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