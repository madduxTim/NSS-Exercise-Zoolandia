namespace Zoolandia
{
    public abstract class Centrolene : Animal
    {
        public Centrolene(string name) : base(name)
        {
            this.Genus = "Centrolene";
            this.Limbs = 4;
            this.Smart = false;          
        }
    }
}