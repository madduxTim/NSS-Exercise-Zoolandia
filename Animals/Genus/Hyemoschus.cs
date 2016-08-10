namespace Zoolandia
{
    public abstract class Hyemoschus : Animal
    {
        public Hyemoschus(string name) : base(name)
        {
            this.Genus = "Hyemoschus";
            this.Limbs = 4;
            this.Smart = false;  
        }
    }
}