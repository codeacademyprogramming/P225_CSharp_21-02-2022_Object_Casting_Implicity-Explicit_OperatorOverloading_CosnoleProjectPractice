using System;
using System.Collections.Generic;
using System.Text;

namespace P225ImplicityExplicity.Models
{
    class Manat
    {
        public double AZN { get; set; }

        public static implicit operator Euro(Manat manat)
        {
            Euro euro = new Euro { Eur = manat.AZN / 1.9293 };
            return euro;
        }

        //public static explicit operator Manat(Euro manat)
        //{
        //    Manat euro = new Manat { AZN = manat.Eur / 1.9293 };
        //    return euro;
        //}

        public static implicit operator Dollar(Manat manat)
        {
            Dollar euro = new Dollar { Usd = manat.AZN / 1.078 };
            return euro;
        }

        public static double operator +(Manat manat1, Manat manat2)
        {
            return manat1.AZN + manat2.AZN;
        }

        public static double operator -(Manat manat1, Manat manat2)
        {
            return manat1.AZN + manat2.AZN;
        }

        public static bool operator >(Manat manat1, Manat manat2)
        {
            return manat1.AZN > manat2.AZN;
        }

        public static bool operator <(Manat manat1, Manat manat2)
        {
            return manat1.AZN < manat2.AZN;
        }
    }
}
