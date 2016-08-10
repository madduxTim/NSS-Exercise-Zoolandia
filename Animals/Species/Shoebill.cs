namespace Zoolandia.Animals 
{
    public class Shoebill : Balaeniceps 
    {
        public Shoebill(string name) : base(name)
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