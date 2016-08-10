namespace Zoolandia
{
    public abstract class Uroplatus : Animal
    {
        public Uroplatus(string name) : base(name)
        {
            this.Genus = "Uroplatus";
            this.Limbs = 4;
            this.Smart = false;           
        }
    }
}