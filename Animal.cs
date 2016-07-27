using System;

namespace Zoolandia 
{
    public class Animal
    {
        public string Name {get; set;} 
        public bool Smart {get; set;}
        public int Limbs {get; set;}

        // 2.1 choose on of the general methods that you created in Animal class and make it virtual.
        // 2.2 override that method in all of your species classes, giving each a more specialized implementation. 
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