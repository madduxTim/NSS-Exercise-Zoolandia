namespace Zoolandia
{
    public abstract class Solenodon : Animal
    {
        public Solenodon(string name) : base(name)
        {
            this.Genus = "Solenodon";
            this.Limbs = 4;
            this.Smart = false;
        }
    }
}