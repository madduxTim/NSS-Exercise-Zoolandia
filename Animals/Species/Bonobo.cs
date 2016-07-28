namespace Zoolandia.Animals 
{
    public class Bonobo : Animal
    {
        public string ScienceName {get;set;}
        public string CommonName {get;set;}
        public Bonobo(bool smart, int limbs) : base(smart, limbs)
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