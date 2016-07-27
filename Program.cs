using System;
using Zoolandia.Species;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {            
            PsittacusErithacus Tobey = new PsittacusErithacus(true, 2);
            Console.WriteLine("Tobey's species = " + Tobey.ScienceName 
            + ". Tobey's actually just a " + Tobey.CommonName 
            + ". Tobey has " + Tobey.Limbs + " feet and as a " + Tobey.CommonName 
            + ", it's " + Tobey.Smart + " that he is pretty smart");

            Console.ReadLine();
        }
    }
}
