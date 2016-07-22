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
            //string response = redPanda.Eat(5);

            //Console.WriteLine(redPanda.Name + " says " + response);

            // AilurusFulgens Joe = new AilurusFulgens("Steve");
            // Console.WriteLine(Joe.Welcome("Joe"));
            // Console.WriteLine(Joe.Name.ToLower());
            
            // LINE BELOW - creates an unhandled exception that let's me to think I don't know what interpolation actually is.
            // Console.WriteLine("My name is Tobey and I'm {9}. That's interpolation I guess.", Bobby.Limbs);
            PanPaniscus Bobby = new PanPaniscus("Bobby", true, 20.5, 4);
            Console.WriteLine(Bobby.Name);
            OrnithorhynchusAnatinus Billy = new OrnithorhynchusAnatinus("Billy", false, 5, 5);
            Console.WriteLine(Billy.Name);
            PanPaniscus Bradley = new PanPaniscus("Bradley", true, 200, 4);
            Console.WriteLine(Bradley.Name);
            TursiopsTruncatus Brandy = new TursiopsTruncatus("Brandy", true, 4, 8);
            Console.WriteLine(Brandy.Name);
            PsittacusErithacus Benny = new PsittacusErithacus("Benny", true, 4, 4);
            Console.WriteLine(Benny.Name);

            Console.ReadLine();
        }
    }
}
