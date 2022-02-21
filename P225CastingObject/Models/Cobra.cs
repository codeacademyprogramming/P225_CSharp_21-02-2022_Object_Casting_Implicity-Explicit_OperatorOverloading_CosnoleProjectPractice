using System;
using System.Collections.Generic;
using System.Text;

namespace P225CastingObject.Models
{
    class Cobra : Reptiel
    {
        public int Length { get; set; }
        public override void Eat()
        {
            Console.WriteLine("Eat As Cobra");
        }
    }
}
