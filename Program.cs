using System;
using System.Collections.Generic;
using Zoolandia.Animals;
using Zoolandia.Habitats;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {            
            AfricanGrey PeteParrot = new AfricanGrey("Pete the Parrot"); 
            Agouta AndyAgouta = new Agouta("Andy the Agouta");
            Almiqui AugustoAlmiqui = new Almiqui("Augusto el Almiqui");
            BlueDragon BobBlueDragon = new BlueDragon("Bob the Blue Dragon");
            Bonobo BennyBonobo = new Bonobo("Benny the Bonobo");
            BottlenoseDolphin DennyDolphin = new BottlenoseDolphin("Denny the Dolphin");
            Chevrotain ChevyChevrotain = new Chevrotain("Chevy the Chevrotain");
            Gelada GerryGelada = new Gelada("Gerry the Gelada");
            GlassFrog FrankFrog = new GlassFrog("Frank the Frog");
            HonduranWhiteBat BrandyBat = new HonduranWhiteBat("Brandy the Bat");
            LeafTailedGecko GordonGecko = new LeafTailedGecko("Gordon the Gecko");
            LongEaredJerboa JeremyJerboa = new LongEaredJerboa("Jeremy the Jerboa");
            Platypus PollyPlatypus = new Platypus("Polly the Platypus");
            Shoebill SharonShoebill = new Shoebill("Sharon the Shoebill");
            TibetanSandFox PhilFox = new TibetanSandFox("Phil the Fox");
            
            Console.WriteLine(SharonShoebill.Name); // Testing 

            Ocean ocean = new Ocean("The Ocean");
            ocean.inhabitants.Add(BobBlueDragon);
            ocean.inhabitants.Add(DennyDolphin);

            Plains plains = new Plains("The Plains");
            plains.inhabitants.Add(GerryGelada);
            plains.inhabitants.Add(ChevyChevrotain);
            plains.inhabitants.Add(JeremyJerboa);
            plains.inhabitants.Add(PollyPlatypus);
            plains.inhabitants.Add(SharonShoebill);
            plains.inhabitants.Add(BennyBonobo);

            RainForest rainforest = new RainForest("Rain Forest");
            rainforest.inhabitants.Add(PeteParrot);
            rainforest.inhabitants.Add(AndyAgouta);
            rainforest.inhabitants.Add(AugustoAlmiqui);
            rainforest.inhabitants.Add(BrandyBat);
            rainforest.inhabitants.Add(FrankFrog);
            rainforest.inhabitants.Add(GordonGecko);

            Steppe steppe = new Steppe("The Steppe");
            steppe.inhabitants.Add(PhilFox);

            List<Habitat> places = new List<Habitat>();
            places.Add(ocean);
            places.Add(plains);
            places.Add(rainforest);
            places.Add(steppe);

            foreach (Habitat place in places)
            {
                Console.WriteLine("Habitat : {0}", place.Name);
                foreach(Animal inhabitant in place.inhabitants)
                {
                    Console.WriteLine(inhabitant.CommonName + " moves like: " + inhabitant.Movement());
                }
            }
        }
    }
}

            //Almiqui Terry = new Almiqui("Terry");
            //Console.WriteLine(Terry.Name + " the " + Terry.CommonName + " moves like: " + Terry.Movement());
            //Terry.Profile();