using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_2
{
     class Chicken : Animal
    {
       public string FeathurColor { get; set; } 
        public Chicken (string feathurColor)
        {
            FeathurColor = feathurColor;
        }
        public override void MakeSound()
        {
            Console.WriteLine("Cluck! Cluck!");
        }
        public override void Move()
        {
            Console.WriteLine("The chicken struts around.");
        }
    }
}
