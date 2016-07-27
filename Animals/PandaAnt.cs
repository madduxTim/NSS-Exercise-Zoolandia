namespace Zoolandia.Animals 
{
    public class PandaAnt : Animal 
    {
        public string ScienceName {get;set;}
        public string CommonName {get;set;}
        public PandaAnt(bool smart, int limbs) : base(smart, limbs)
        {
            this.ScienceName = "Mutillidae";
            this.CommonName = "Panda Ant"; 
        }
        public int Company {get;set;}
        public override string Movement()
        {
            return "Crawls." ;
        }
        public override float Speed()
        {
            return 4;
        }
    }
}