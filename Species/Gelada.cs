namespace Zoolandia.Species 
{
    public class Gelada : Animal 
    {
        public string ScienceName {get;set;}
        public string CommonName {get;set;}
        public Gelada(bool smart, int limbs) : base(smart, limbs)
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