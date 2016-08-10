namespace Zoolandia.Animals 
{
    public class Gelada : Theropithecus 
    {
        public Gelada(string name) : base(name)
        {
            this.ScienceName = "Theropithecus gelada";
            this.CommonName = "Gelada"; 
        }
        public int Company {get;set;}
        public override string Movement()
        {
            return "Can definitely " + base.Movement();
        }
        public override float Speed()
        {
            return 4;
        }
    }
}