namespace Zoolandia.Animals 
{
    public class BlueDragon : Glaucus 
    {
        public BlueDragon(string name) : base(name)
        {
            this.ScienceName = "Glaucus atlanticus";
            this.CommonName = "Blue Dragon"; 
        }
        public int Company {get;set;}
        public override string Movement()
        {
            return "Swims." ;
        }
        public override float Speed()
        {
            return 4;
        }
    }
}