namespace Zoolandia.Animals 
{
    public class Platypus : Animal
    {
        public string ScienceName {get;set;}
        public string CommonName {get;set;}
        public Platypus(bool smart, int limbs) : base(smart, limbs)
        {
            this.ScienceName = "Ornithorhynchus anatinus";
            this.CommonName = "Platypus"; 
        }
        public int Paddle {get;set;}
        
        public override string Movement()
        {
            return "Can't really " + base.Movement() + ". More like a waddle...";
        }
        public override float Speed()
        {
            return 2.002f;
        }
    }
}