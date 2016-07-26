using System; // hooks you up with System library from .NET

// namespace roughly means scope
namespace Zoolandia 
{
    public class Animal
    {
        // 1.1 - create some simple properties and methods on Animal. 
        // 1.1 - simple properties
        public string Name {get; set;} 
        public bool Smart {get; set;}
        public int Limbs {get; set;}
        // 1.1 - simple methods
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
            Console.WriteLine(this.Name + this.Smart + this.Limbs);
        }
    }
}