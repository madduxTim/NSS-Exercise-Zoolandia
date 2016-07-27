namespace Zoolandia.Species 
{
    public class OrnithorhynchusAnatinus : Animal
    {
        public string ScienceName {get;set;}
        public string CommonName {get;set;}
        public OrnithorhynchusAnatinus(bool smart, int limbs) : base(smart, limbs)
        {
            this.ScienceName = "Ornithorhynchus Anatinus";
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