namespace Zoolandia
{
    public class Animal
    {
        public Animal(bool smart, int limbs)
        {
            this.Smart = smart;
            this.Limbs = limbs;
        }
        public string Name {get; set;} 
        public bool Smart {get; set;}
        public int Limbs {get; set;}

        public virtual string Movement()
        {
            return "perambulate";
        }
        public virtual float Speed()
        {
            return 0.0f; 
        }
        public void Profile()
        {
            System.Console.WriteLine(this.Name + this.Smart + this.Limbs);
        }
    }
}