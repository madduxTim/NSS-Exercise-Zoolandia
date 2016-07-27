namespace Zoolandia.Species 
{
    public class Agouta : Animal 
    {
        public string ScienceName {get;set;}
        public string CommonName {get;set;}
        public Agouta(bool smart, int limbs) : base(smart, limbs)
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