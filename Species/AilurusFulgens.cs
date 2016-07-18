using System;

// take note of the .Species directory structure
namespace Zoolandia.Species 
{
    public class AilurusFulgens : Animal
    {

        public AilurusFulgens(string name) : base(name) 
        {
            //don't need to do anything 
        }
        public override string Eat(int numberOfFoodz)
        {
            string animalEat = base.Eat(3);
            return animalEat + " Nom nom nom";
        }

        public string Eat() {
            return "I don't know what I ate, but it was good"; // this is overriding the other method. 
            // this is going to be very helpful apparently
        }

        public string Welcome (string name)
        {
            this.Name = name;
            return Welcome();
        }

        public string Welcome()
        {
            return "Welcome, " + this.Name;
        }
    }
}