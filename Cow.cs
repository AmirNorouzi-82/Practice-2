using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_2
{
    class Cow : Animal
    {
        public string Breed { get; set; }
        public Cow(string breed)
        {
            Breed = breed;
        }
        public override void MakeSound()
        {
            Console.WriteLine("Moo!");
        }
        public override void Move()
        {
            Console.WriteLine("The cow walks slowly on all fours. ");
        }
        public void ProduceMilk()
        {
            Console.WriteLine("The cow produces milk.");
        }
    }
}




    
