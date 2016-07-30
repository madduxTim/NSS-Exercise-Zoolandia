namespace Zoolandia
{
    public abstract class Tursiops : Animal
    {
        public Tursiops(string name) : base(name)
        {
            this.Genus = "Tursiops";
            this.Limbs = 3;
            this.Smart = true;        
        }
    }
}