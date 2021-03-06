using System.Collections.Generic;
using Zoolandia.Animals;

namespace Zoolandia.Habitats
{
    public abstract class Habitat
    {
        public Habitat(string name)
        {
            this.Name = name;
        }
        public List<Animal> inhabitants = new List<Animal>();
        public string Name {get;set;} 
        public bool isUnderWater {get;set;}
   }
}