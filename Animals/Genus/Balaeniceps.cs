namespace Zoolandia
{
    public abstract class Balaeniceps : Animal
    {
        public Balaeniceps(string name) : base(name)
        {
            this.Genus = "Balaeniceps";
            this.Limbs = 4;
            this.Smart = false;
        }
    }
}