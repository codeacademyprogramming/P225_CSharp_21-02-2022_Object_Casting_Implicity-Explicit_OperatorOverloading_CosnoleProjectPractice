using System;
using System.Collections.Generic;
using System.Text;

namespace P225CastingObject.Models
{
    class Human
    {
        public string Name { get; set; }
        public string SurName { get; set; }

        public string GetFullName()
        {
            return $"{Name} {SurName}";
        }

        public override string ToString()
        {
            return $"{Name} {SurName}";
        }
    }
}
