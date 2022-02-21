using System;
using System.Collections.Generic;
using System.Text;

namespace P225ImplicityExplicity.Models
{
    class Euro
    {
        public double Eur { get; set; }

        public static explicit operator Manat(Euro euro)
        {
            return new Manat { AZN = euro.Eur * 2.1 };
        }
    }
}
