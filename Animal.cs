using System; // hooks you up with System library from .NET

// namespace roughly means scope
namespace Zoolandia 
{
    public class Animal
    {
        
        public Animal (string name)
        {
            this.Name = name;
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
            return "Perambulate!";
        }
        // Profile constructor method returns both integer and string arguments (as well and boolean and double just for fun)
        public void Who(string name)
        {
            this.Name = name;
            // Console.WriteLine(name);
            // return this.Name; //When I don't commented this out, it throws this error: 
                // "returns void, a return keyword must not be followed by an object expression" 
                // WHAT DO I CHANGE VOID TO? Virtual throws different error
        }
        public void Profile()
        {
            Console.WriteLine(this.Name + this.Smart + this.Weight + this.Limbs);
        }
    }
}