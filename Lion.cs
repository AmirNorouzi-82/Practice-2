using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_2
{
    internal class Lion : Animal
    {
        public bool IsKingOfTheJungle { get; set; }   
        public Lion( bool iskingofthejungle) 
        {
            IsKingOfTheJungle = iskingofthejungle;
        }
        public override void MakeSound()
        {
            Console.WriteLine("the lion roars loudly");
        }
        public override void Move()
        {
            Console.WriteLine("The lion prowls gracefully.");
        }
        public void Hunt () 
        {
            Console.WriteLine("The lion hunts for prey.");
        }
    }
}
