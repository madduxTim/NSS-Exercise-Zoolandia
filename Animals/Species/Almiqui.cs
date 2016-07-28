namespace Zoolandia.Animals 
{
    public class Almiqui : Animal 
    {
        public string ScienceName {get;set;}
        public string CommonName {get;set;}
        public Almiqui(bool smart, int limbs) : base(smart, limbs)
        {
            this.ScienceName = "Solenodon Cubanus";
            this.CommonName = "Almiqui"; 
        }
        public int Company {get;set;}
        public override string Movement()
        {
            return "Ambladura y escabullen." ;
        }
        public override float Speed()
        {
            return 4;
        }
    }
}