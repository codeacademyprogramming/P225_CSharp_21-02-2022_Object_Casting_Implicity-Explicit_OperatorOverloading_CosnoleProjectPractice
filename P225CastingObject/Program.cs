using P225CastingObject.Models;
using System;

namespace P225CastingObject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Human human = new Human();
            //human.Name = "Hamid";
            //human.SurName = "Mammadov";

            //Console.WriteLine(human);
            //Console.WriteLine(human);
            //Console.WriteLine(human);
            //Console.WriteLine(human);
            //Console.WriteLine(human);
            //Console.WriteLine(human.GetType());

            Animal eagle1 = new Eagle { Age = 35 };

            Eagle eagle2 = new Eagle { Age = 45 };
            Eagle eagle3 = new Eagle { Age = 55 };

            //Eagle[] eagles = { eagle1, eagle2, eagle3};


            Cobra cobra1 = new Cobra { Length = 50 };
            Cobra cobra2 = new Cobra { Length = 70 };
            Cobra cobra3 = new Cobra { Length = 90 };

            //Cobra[] cobras = { cobra1, cobra2, cobra3 };

            Animal[] animals = new Animal[] { cobra2,  eagle2, eagle3, cobra1,  cobra3, eagle1 };



            //Tehlukeli Yol
            //Cobra cobra = (Cobra)animals[0];
            //Console.WriteLine(cobra.Length);

            //Tehlukesiz Yol version - 1
            //Console.WriteLine(animals[0] is Eagle);
            //foreach (Animal item in animals)
            //{
            //    if (item is Eagle)
            //    {
            //        Eagle eagle = (Eagle)item;
            //        Console.WriteLine(eagle.Age);
            //    }
            //    else if(item is Cobra)
            //    {
            //        Cobra cobra = (Cobra)item;
            //        Console.WriteLine(cobra.Length);
            //    }
            //}

            //Tehlukesiz Yol version -2
            //Cobra eagle = animals[0] as Cobra;
            //Console.WriteLine(eagle);

            foreach (Animal item in animals)
            {
                Cobra cobra = item as Cobra;

                if (cobra != null)
                {
                    Console.WriteLine(cobra.Length);
                }
                else
                {
                    Eagle eagle = item as Eagle;
                    Console.WriteLine(eagle.Age);
                }
            }
        }

        //public static void Get(Animal animal)
        //{

        //}

        public static Animal[] Get(Animal[] animals)
        {
            Animal[] newCobra = new Animal[0];

            foreach (Cobra item in animals)
            {
                if (item.Length > 35)
                {
                    Array.Resize(ref newCobra, newCobra.Length + 1);
                    newCobra[newCobra.Length - 1] = item;
                }
            }

            return newCobra;
        }

        //public static Eagle[] GetEagles(Eagle[] eagles)
        //{
        //    Eagle[] newEagle = new Eagle[0];

        //    foreach (Eagle item in eagles)
        //    {
        //        if (item.Age > 35)
        //        {
        //            Array.Resize(ref newEagle, newEagle.Length + 1);
        //            newEagle[newEagle.Length-1] = item;
        //        }
        //    }

        //    return newEagle;
        //}

        //public static Cobra[] GetEagles(Cobra[] cobras)
        //{
        //    Cobra[] newCobra = new Cobra[0];

        //    foreach (Cobra item in cobras)
        //    {
        //        if (item.Length > 35)
        //        {
        //            Array.Resize(ref newCobra, newCobra.Length + 1);
        //            newCobra[newCobra.Length - 1] = item;
        //        }
        //    }

        //    return newCobra;
        //}
    }
}
