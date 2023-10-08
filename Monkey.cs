using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Practice_2
{
     class Monkey : Animal
    {
        public bool SwingsOnTrees { get; set; } 
        public Monkey (bool swingsOnTrees)
        {
            SwingsOnTrees = swingsOnTrees;
        }
        public override void MakeSound()
        {
            Console.WriteLine("Ooh! Ooh! Aah! Aah! ");
        }
        public override void Move()
        {
            Console.WriteLine("The monkey swings from branch to branch. ");
        }
    }
}
