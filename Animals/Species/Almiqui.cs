namespace Zoolandia.Animals 
{
    public class Almiqui : Solenodon 
    {
        public Almiqui(string name) : base(name)
        {
            this.ScienceName = "Solenodon Cubanus";
            this.CommonName = "Almiqui"; 
        }
        public int Company {get;set;}
        public override string Movement()
        {
            return "Ambladura y escabullen." ;
        }
        public override float Speed()
        {
            return 4;
        }
    }
}