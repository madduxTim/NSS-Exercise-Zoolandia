namespace Zoolandia
{
    public abstract class Psittacus : Animal
    {
        public Psittacus(string name) : base(name)
        {
            this.Genus = "Psittacus";
            this.Limbs = 2;
            this.Smart = true;
        }
    }
}