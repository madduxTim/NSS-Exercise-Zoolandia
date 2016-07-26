using System;
using Zoolandia.Species;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //AilurusFulgens redPanda = new AilurusFulgens("Steve", false, 18.5, 4);
            //redPanda.Name = "Steve";
            //string response = redPanda.Eat(3);
            //Console.WriteLine(redPanda.Name + " says " + response);
            // AilurusFulgens Joe = new AilurusFulgens("Steve");
            // Console.WriteLine(Joe.Welcome("Joe"));
            // Console.WriteLine(Joe.Name.ToLower());
            
            PanPaniscus Bobby = new PanPaniscus("Bobby", true, 20.5, 4);
            Console.WriteLine(Bobby.Name);
            OrnithorhynchusAnatinus Billy = new OrnithorhynchusAnatinus("Billy", false, 5, 5);
            Console.WriteLine(Billy.Name);
            Console.WriteLine(Billy.Movement());
            PanPaniscus Bradley = new PanPaniscus("Bradley", true, 200, 4);
            Console.WriteLine(Bradley.Name);
            TursiopsTruncatus Brandy = new TursiopsTruncatus("Brandy", true, 4, 8);
            Console.WriteLine(Brandy.Name);
            PsittacusErithacus Parrot = new PsittacusErithacus("Benny", true, 4, 4);
            Console.WriteLine(Parrot.Name);
            Parrot.Who("Johnson");
            Console.WriteLine(Parrot.Movement()); 

            Console.ReadLine();
        }
    }
}
