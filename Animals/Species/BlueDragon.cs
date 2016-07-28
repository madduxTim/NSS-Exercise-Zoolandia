namespace Zoolandia.Animals 
{
    public class BlueDragon : Animal 
    {
        public string ScienceName {get;set;}
        public string CommonName {get;set;}
        public BlueDragon(bool smart, int limbs) : base(smart, limbs)
        {
            this.ScienceName = "Glaucus atlanticus";
            this.CommonName = "Blue Dragon"; 
        }
        public int Company {get;set;}
        public override string Movement()
        {
            return "Swims." ;
        }
        public override float Speed()
        {
            return 4;
        }
    }
}