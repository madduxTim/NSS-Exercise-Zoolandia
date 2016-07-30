namespace Zoolandia
{
    public abstract class Animal
    {
        public Animal(string name){
            this.Name = name; 
        }
        //can't have a second instance of Animal with only string param type
        public string Genus {get;set;} // set at Genus 
        public bool Smart {get; set;} // set at Genus 
        public int Limbs {get; set;} // set at Genus 
        public string ScienceName {get;set;}
        public string CommonName {get;set;}
        public string Name {get; set;} 

        public virtual string Movement()
        {
            return "move";
        }
        public virtual float Speed()
        {
            return 0.0f; 
        }
        public void Profile()
        {
            System.Console.WriteLine(this.Name + " is what is known as a "
            + this.ScienceName + ", commonly known as a " + this.CommonName 
            + ", which is part of the genus " + this.Genus + ". A " + this.ScienceName
            + " has " + this.Limbs + " limbs, and it is generally " + this.Smart + " they are intelligent.");
        }
    }
}