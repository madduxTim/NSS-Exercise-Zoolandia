using System;
using Zoolandia.Species;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {            
            TibetanSandFox Terry = new TibetanSandFox(true, 2);
            Console.WriteLine(Terry.ScienceName + " moves like: " + Terry.Movement());

            Console.ReadLine();
        }
    }
}
