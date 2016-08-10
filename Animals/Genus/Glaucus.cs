namespace Zoolandia
{
    public abstract class Glaucus : Animal
    {
        public Glaucus(string name) : base(name)
        {
            this.Genus = "Glaucus";
            this.Limbs = 3;
            this.Smart = false;
        }
    }
}