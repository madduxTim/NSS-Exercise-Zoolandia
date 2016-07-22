using System; // hooks you up with System library from .NET

// namespace roughly means scope
namespace Zoolandia 
{
    public class Animal
    {
        public Animal (string name, bool smart, double weight, int limbs)
        {
            this.Name = name;
            this.Smart = smart;
            this.Weight = weight;
            this.Limbs = limbs;
        }

        public string Name {get; set;}
        public bool Smart {get; set;}
        public double Weight {get; set;}
        public int Limbs {get; set;}
        public virtual string Eat(int numberOfFoodz)
        {
            return "YUM!"; // make it virtual so that it can be overwritten
        }
        public virtual string Movement()
        {
            return "perambulate";
        }
        public void Profile()
        {
            Console.WriteLine(this.Name + this.Smart + this.Weight + this.Limbs);
        }
    }
}