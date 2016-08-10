namespace Zoolandia
{
    public abstract class Ornithorhynchus : Animal
    {
        public Ornithorhynchus(string name) : base(name)
        {
            this.Genus = "Ornithorhynchus";
            this.Limbs = 4;
            this.Smart = false;    
        }
    }
}