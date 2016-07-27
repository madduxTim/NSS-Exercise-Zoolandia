namespace Zoolandia.Species 
{
    public class GlassFrog : Animal 
    {
        public string ScienceName {get;set;}
        public string CommonName {get;set;}
        public GlassFrog(bool smart, int limbs) : base(smart, limbs)
        {
            this.ScienceName = "Centrolene geckoideum";
            this.CommonName = "Glass Frog"; 
        }
        public int Company {get;set;}
        public override string Movement()
        {
            return "Hops." ;
        }
        public override float Speed()
        {
            return 4;
        }
    }
}