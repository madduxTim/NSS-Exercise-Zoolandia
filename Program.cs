using System;
using Zoolandia.Animals;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {            
            Almiqui Terry = new Almiqui("Terry");
            Console.WriteLine(Terry.Name + " the " + Terry.CommonName + " moves like: " + Terry.Movement());
            Terry.Profile();

            Console.ReadLine();
        }
    }
}
