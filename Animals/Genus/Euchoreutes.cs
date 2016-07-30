namespace Zoolandia
{
    public abstract class Euchoreutes : Animal
    {
        public Euchoreutes(string name) : base(name)
        {
            this.Genus = "Euchoreutes";
            this.Limbs = 4;
            this.Smart = false;          
        }
    }
}