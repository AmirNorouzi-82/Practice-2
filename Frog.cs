using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_2
{
     class Frog : Animal
    {
        public bool IsAquatic { get; set; }
        public Frog(bool isAquatic)
        {
            IsAquatic = isAquatic;
        }
        public override void MakeSound()
        {
            Console.WriteLine("Ribbit! Ribbit! ");
        }
        public override void Move()
        {
            Console.WriteLine("The frog jumps around. ");
        }
    }
}
