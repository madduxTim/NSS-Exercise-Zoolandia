namespace Zoolandia.Animals 
{
    public class LongEaredJerboa : Euchoreutes 
    {
        public LongEaredJerboa(string name) : base(name)
        {
            this.ScienceName = "Euchoreutes naso";
            this.CommonName = "Long-eared Jerboa"; 
        }
        public int Company {get;set;}
        public override string Movement()
        {
            return "Hops and scoots I imagine." ;
        }
        public override float Speed()
        {
            return 4;
        }
    }
}