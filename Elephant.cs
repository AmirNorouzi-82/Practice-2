using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_2
{
     class Elephant : Animal
    {
        public bool HasTrunk { get; set; }
        public Elephant(bool hasTrunk)
        {
            HasTrunk = hasTrunk;
        }
        public override void MakeSound()
        {
            Console.WriteLine("Trumpet!");
        }
        public override void Move()
        {
            Console.WriteLine("The elephant walks slowly and swings its trunk.");
        }
    }
}
