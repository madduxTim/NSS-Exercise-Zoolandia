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

        // private string _name; // this is a private variable. Conventional to put in underscore beforehand.
        public string Name {get; set;} // Name is not a keyword. This is property of Animal

        public virtual string Eat(int numberOfFoodz)
        {
            return "YUM!"; // make it virtual so that it can be overwritten
        }
    }
}