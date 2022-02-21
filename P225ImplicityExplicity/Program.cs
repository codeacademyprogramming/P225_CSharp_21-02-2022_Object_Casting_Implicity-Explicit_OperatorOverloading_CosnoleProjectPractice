using P225ImplicityExplicity.Models;
using System;

namespace P225ImplicityExplicity
{
    class Program
    {
        static void Main(string[] args)
        {
            Manat manat = new Manat();
            manat.AZN = 5001;

            Manat manat1 = new Manat();
            manat1.AZN = 500;

            //Euro euro = manat;
            //Console.WriteLine(euro.Eur);

            //Manat manat1 = (Manat)euro;
            //Console.WriteLine(manat1.AZN);
            Manat manat2 = new Manat();
            manat2.AZN = manat + manat1;
            Console.WriteLine(manat2 + manat1);
        }
    }
}
