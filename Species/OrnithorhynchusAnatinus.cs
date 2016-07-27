namespace Zoolandia.Species 
{
    // Platypus
    public class OrnithorhynchusAnatinus : Animal
    {
        //Createa constructor function for each of your animals. 
        //The constructor fuctnion should, at the very least, set the 
        //initial name of all animals of that type to a name of your choosing. 
        public string ScienceName {get;set;}
        public string CommonName {get;set;}
        public OrnithorhynchusAnatinus()
        {
            this.ScienceName = "Ornithorhynchus Anatinus";
            this.CommonName = "Platypus"; 
        }
        public int Paddle {get;set;}
        
        //2.3 Make sure you invoke the parent class' overridden method with the base reference 
        public override string Movement()
        {
            return "Can't really " + base.Movement() + ". More like a waddle...";
        }
        public override float Speed()
        {
            return 2.002f;
        }
    }
}