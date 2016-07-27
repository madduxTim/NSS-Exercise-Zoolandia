namespace Zoolandia.Species 
{
    public class Chevrotain : Animal 
    {
        public string ScienceName {get;set;}
        public string CommonName {get;set;}
        public Chevrotain(bool smart, int limbs) : base(smart, limbs)
        {
            this.ScienceName = "Hyemoschus aquaticus";
            this.CommonName = "Chevrotain"; 
        }
        public int Company {get;set;}
        public override string Movement()
        {
            return "Ambles." ;
        }
        public override float Speed()
        {
            return 4;
        }
    }
}