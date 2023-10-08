namespace Practice_2
{
     class Program
    {
        static void Main(string[] args)
        {
            Frog frog = new Frog(true);
            Cow cow = new Cow("Holstein");
            Bear bear = new Bear(true);
            Cat cat = new Cat(true);
            Chicken chicken = new Chicken("White"); 
            Monkey monkey = new Monkey (true);  
            Lion lion = new Lion (true);
            Elephant elephant = new Elephant (true);

            Console.WriteLine("Frog:");
            Console.WriteLine("Is Aquatic:" + frog.IsAquatic);
            frog.MakeSound();
            frog.Move();
            Console.WriteLine();


            Console.WriteLine("Cow:");
            Console.WriteLine("Breed:" + cow.Breed);
            cow.MakeSound();
            cow.Move();
            cow.ProduceMilk();
            Console.WriteLine();


            Console.WriteLine("Bear:");
            Console.WriteLine("Hibernates:" + bear.Hibernates);
            bear.MakeSound();
            bear.Move();
            Console.WriteLine();


            Console.WriteLine("Cat:");
            Console.WriteLine("Is Lazy: " + cat.IsLazy);
            cat.MakeSound();
            cat.Move();
            cat.Scratch();
            Console.WriteLine();


            Console.WriteLine("Chicken:");
            Console.WriteLine("Feather Color:" + chicken.FeathurColor);
            chicken.MakeSound();   
            chicken.Move();
            Console.WriteLine();


            Console.WriteLine("Lion:");
            Console.WriteLine("Is King Of The Jungle: " + lion.IsKingOfTheJungle);
            lion.MakeSound();
            lion.Move();
            lion.Hunt();
            Console.WriteLine();


            Console.WriteLine("Elephant:");
            Console.WriteLine("Has Trunk: " + elephant.HasTrunk);
            elephant.MakeSound();
            elephant.Move();
            
            Console.Read ();
        }
    }
}