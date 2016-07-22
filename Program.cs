using System;
using Zoolandia.Species;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AilurusFulgens redPanda = new AilurusFulgens("Steve", false, 18.5, 4);
            redPanda.Name = "Steve";
            string response = redPanda.Eat(5);

            Console.WriteLine(redPanda.Name + " says " + response);

            // AilurusFulgens Joe = new AilurusFulgens("Steve");
            // Console.WriteLine(Joe.Welcome("Joe"));
            // Console.WriteLine(Joe.Name.ToLower());
            
            PanPaniscus Bobby = new PanPaniscus("Bobby", true, 20.5, 4);
            Bobby.Profile();

            Console.ReadLine();
        }
    }
}
