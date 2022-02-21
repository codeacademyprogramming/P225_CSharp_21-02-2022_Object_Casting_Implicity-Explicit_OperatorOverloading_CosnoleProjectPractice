using System;
using System.Collections.Generic;
using System.Text;

namespace P225CastingObject.Models
{
    class Eagle : Bird
    {
        public int Age { get; set; }
        public override void Eat()
        {
            Console.WriteLine("Eat As Eagle");
        }

        public override void Fly()
        {
            Console.WriteLine("Fly As Eagle");
        }
    }
}
