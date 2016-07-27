namespace Zoolandia.Species 
{
    public class LongEaredJerboa : Animal 
    {
        public string ScienceName {get;set;}
        public string CommonName {get;set;}
        public LongEaredJerboa(bool smart, int limbs) : base(smart, limbs)
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