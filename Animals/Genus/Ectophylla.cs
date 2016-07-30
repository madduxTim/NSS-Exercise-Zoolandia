namespace Zoolandia
{
    public abstract class Ectophylla : Animal
    {
        public Ectophylla(string name) : base(name)
        {
            this.Genus = "Ectophylla";
            this.Limbs = 4;
            this.Smart = false;          
        }
    }
}