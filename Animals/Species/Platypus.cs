namespace Zoolandia.Animals 
{
    public class Platypus : Ornithorhynchus
    {
        public Platypus(string name) : base(name)
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