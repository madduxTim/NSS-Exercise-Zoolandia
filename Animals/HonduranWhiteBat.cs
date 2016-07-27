namespace Zoolandia.Animals 
{
    public class HonduranWhiteBat : Animal 
    {
        public string ScienceName {get;set;}
        public string CommonName {get;set;}
        public HonduranWhiteBat(bool smart, int limbs) : base(smart, limbs)
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