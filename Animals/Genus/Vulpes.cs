namespace Zoolandia
{
    public abstract class Vulpes : Animal
    {
        public Vulpes(string name) : base(name)
        {
            this.Genus = "Vulpes";
            this.Limbs = 4;
            this.Smart = false;
        }
    }
}