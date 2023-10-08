using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_2
{
     class Bear : Animal
    {
        public bool Hibernates { get; set; }
        public Bear( bool hibernates ) 
        {
            Hibernates = hibernates;
        }
        public override void MakeSound()
        {
            Console.WriteLine("Roar!");
        }
        public override void Move()
        {
            Console.WriteLine("The bear walks on all fours. ");
        }
    }
}
