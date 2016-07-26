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
            
            PanPaniscus Bobby = new PanPaniscus("Bobby");
            Console.WriteLine(Bobby.Name);
            OrnithorhynchusAnatinus Billy = new OrnithorhynchusAnatinus("Billy");
            Console.WriteLine(Billy.Name);
            Console.WriteLine(Billy.Movement());
            PanPaniscus Bradley = new PanPaniscus("Bradley");
            Console.WriteLine(Bradley.Name);
            TursiopsTruncatus Brandy = new TursiopsTruncatus("Brandy");
            Console.WriteLine(Brandy.Name);
            PsittacusErithacus Parrot = new PsittacusErithacus("Benny");
            Console.WriteLine(Parrot.Name);
            Parrot.Who("Johnson");
            Console.WriteLine(Parrot.Movement()); 

            Console.ReadLine();
        }
    }
}
