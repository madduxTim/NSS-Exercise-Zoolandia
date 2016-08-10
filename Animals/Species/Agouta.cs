namespace Zoolandia.Animals 
{
    public class Agouta : Solenodon 
    {
        public Agouta(string name) : base(name)
        {
            this.ScienceName = "Solenodon Paradoxus";
            this.CommonName = "Agouta";
        }
        public int Company {get;set;}
        public override string Movement()
        {
            return "Ambles and meanders." ;
        }
        public override float Speed()
        {
            return 4;
        }
    }
}