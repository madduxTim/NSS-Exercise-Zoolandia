namespace Zoolandia.Animals 
{
    public class Bonobo : Pan
    {
        public Bonobo(string name) : base(name)
        {
            this.ScienceName = "Pan Paniscus";
            this.CommonName = "Bonobo"; 
        }
        public int Troop {get;set;}

        public override string Movement()
        {
            return "Climb and " + base.Movement(); 
        }
        public override float Speed()
        {
            return 5;
        }
    }
}