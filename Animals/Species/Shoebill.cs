namespace Zoolandia.Animals 
{
    public class Shoebill : Animal 
    {
        public string ScienceName {get;set;}
        public string CommonName {get;set;}
        public Shoebill(bool smart, int limbs) : base(smart, limbs)
        {
            this.ScienceName = "Balaeniceps rex";
            this.CommonName = "Shoebill"; 
        }
        public int Company {get;set;}
        public override string Movement()
        {
            return "Lumbers." ;
        }
        public override float Speed()
        {
            return 4;
        }
    }
}