using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace template_csharp_virtual_pet
{
    public class Robotic : Pet
    {
        private string robot;

        public string Robot { get; set; }
        public Robotic(int petHunger, string petName, string petSpecies, string petColor, int petHealth, int petBoredom, string petType, string robot) : base (petHunger,petName, petSpecies,petColor, petHealth, petBoredom,petType)
        {
            Robot = robot;

        }
        public override void PetsNameAndSpecies()
        {
            Console.WriteLine("Will your pet be robotic or organic? Yes or No");
            string userInput = Console.ReadLine().ToLower();
            if (userInput == "yes")
            {

            }

            base.PetsNameAndSpecies();
            
        }
        public override void PetsHealth()
        {
            base.PetsHealth();
        }
        public override void Play()
        {

            Console.WriteLine("Your robot is playing with the rebar you gave it.");
            
        }
        public void Charge()
        {
            Console.Title = "A Pet's Life by Blue Falcon Group";
            Console.Clear();
            Display();

            if (Hunger == 0)
            {
                Console.WriteLine("Your robot pet does not need any more charge.");
                base.Feed();
            }
            else
            {
                Console.WriteLine("Your robotic pet is munching on nuts and bolts");
            }
        }
        public override void Vet()
        {
            Console.WriteLine("Your robotic pet just needed and oil bath. They are all better now");
            base.Vet();
        }
        public override void Display()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Pet Status:");
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Color/Species: {Color} {Species}");
            Console.WriteLine($"Pet Type: {Type}");
            Console.WriteLine($"Health: {Health}");
            Console.WriteLine($"Boredom: {Boredom}");
            Console.WriteLine($"Hunger: {Hunger}");
        }
    }
}
