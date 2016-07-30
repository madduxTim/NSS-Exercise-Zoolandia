namespace Zoolandia.Animals 
{
    public class Chevrotain : Hyemoschus 
    {
        public Chevrotain(string name) : base(name)
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