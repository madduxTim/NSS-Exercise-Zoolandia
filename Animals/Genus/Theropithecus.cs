namespace Zoolandia
{
    public abstract class Theropithecus : Animal
    {
        public Theropithecus(string name) : base(name)
        {
            this.Genus = "Theropithecus";
            this.Limbs = 4;
            this.Smart = true; 
        }
    }
}