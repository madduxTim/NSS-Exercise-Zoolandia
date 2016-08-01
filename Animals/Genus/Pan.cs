namespace Zoolandia
{
    public abstract class Pan : Animal
    {
        public Pan(string name) : base(name)
        {
            this.Genus = "Pan";
            this.Limbs = 4;
            this.Smart = true;
        }
    }
}