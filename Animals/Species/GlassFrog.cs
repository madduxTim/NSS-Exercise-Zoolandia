namespace Zoolandia.Animals 
{
    public class GlassFrog : Centrolene 
    {
        public GlassFrog(string name) : base(name)
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