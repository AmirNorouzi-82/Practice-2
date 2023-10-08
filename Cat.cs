using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_2
{
     class Cat : Animal
    {
        public bool IsLazy { get; set; }
        public Cat (bool islazy)
        {
            IsLazy = islazy;
        }
        public override void MakeSound()
        {
            Console.WriteLine("Meow!");
        }
        public override void Move()
        {
            Console.WriteLine("The cat walks and sometimes jumps.");
        }
        public void Scratch() 
        {
            Console.WriteLine("The cat Scartchs the furniture.");
        }
    }
}
