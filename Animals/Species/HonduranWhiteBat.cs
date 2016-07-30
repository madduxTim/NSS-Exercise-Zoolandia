namespace Zoolandia.Animals 
{
    public class HonduranWhiteBat : Ectophylla 
    {
        public HonduranWhiteBat(string name) : base(name)
        {
            this.ScienceName = "Ectophylla alba";
            this.CommonName = "Honduran White Bat"; 
        }
        public int Company {get;set;}
        public override string Movement()
        {
            return "Flys." ;
        }
        public override float Speed()
        {
            return 4;
        }
    }
}