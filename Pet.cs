using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template_csharp_virtual_pet
{
    public class Pet
    {
        //fields/instance variables
        private int hunger;
        private string name;
        private string species;
        private string color;
        private int health;
        private int bordem;
        private string type;

        //properties
        public int Hunger { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
        public string Color { get; set; }
        public int Health { get; set; }
        public int Boredom { get; set; }
        public string Type { get; set; }

        //Constructor
        public Pet(int petHunger, string petName, string petSpecies, string petColor, int petHealth, int petBoredom,string petType)
        {
            Hunger = petHunger;
            Name = petName;
            Species = petSpecies;
            Color = petColor;
            Health = petHealth;
            Boredom = petBoredom;
            Type = petType;
        }

        public Pet()
        {

        }

        public virtual void PetsNameAndSpecies()
        {
            Console.WriteLine("Pick a species: Bird, Dog, Cat, Rabbit:");
            Species = Console.ReadLine().ToLower();

            Console.WriteLine("Pick a type: Robotic or Organic:");
            Type = Console.ReadLine().ToLower();

            Console.WriteLine("Name your pet");
            Name = Console.ReadLine().ToLower();

            if (Species == "bird")
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Congrats! You are now the proud owner the legendary Blue Falcon!!!");
                Console.WriteLine("     | \r\n____________    __ -+-  ____________ \r\n\\_____     /   /_ \\ |   \\     _____/\r\n \\_____    \\____/  \\____/    _____/\r\n  \\_____                    _____/\r\n     \\___________  ___________/\r\n               /____\\");
            }

            Console.WriteLine("Pick your pet's Color: ");
            Color = Console.ReadLine();
            Console.WriteLine("Congrats! You are now the proud owner of a " +  Color  +" "+  Type + " " +  Species + " " + "named " + Name);
        }
        
        public virtual void PetsHealth()
        {
            Health--;
            if (Health <= 0)
            {
                Console.WriteLine("Your pet is dead. Good job idiot. Your case is now being investigated by Animal Services");
            }
        }
        public virtual void Play()
        {
            Console.Title = "A Pet's Life by Blue Falcon Group";
            Console.Clear();
            Display();

            if (Boredom < 10 && Boredom > 0 && Hunger < 10)
            {
                Console.WriteLine("You played with your pet");
                Boredom -= 2;
                Hunger++;
            }
            else if (Hunger == 10)
            {
                Console.WriteLine("Go feed your pet, irresponsible owner.");
            }
            else if (Boredom == 0)
            {
                Console.WriteLine("Your pet is tired. Go do something else.");
                Hunger++;
            }
            

        }

        public virtual void Feed()
        {
            Console.Title = "A Pet's Life by Blue Falcon Group";
            Console.Clear();
            Display();
            
            if (Hunger == 0)
            {
                Boredom++;
                Console.WriteLine("Your Pet is full.");
            }
            else
            {
                Hunger -=2;
                Console.WriteLine("You fed your pet");
            }
            
                
        }

        public virtual void Vet()
        {
            Console.Title = "A Pet's Life by Blue Falcon Group";
            Console.Clear();
            Display();

            if (Health >= 10)
            {
                Console.WriteLine("Your pet is healthy.");
            }
            else
            {
                Health += 2;
                Console.WriteLine("Your pet's health points restored by 2.");
            }
        }

        public virtual void Tick()
        {
            Hunger++;
            Boredom++;
            Health--;

            //Health
            if (Health > 10)
            {
                Health = 10;
            }

            if (Health <= 0)
            {
                Health = 0;
                Console.WriteLine("Your pet is dead. Good job idiot. Your case is now being investigated by Animal Services");
            }

            //Boredom
            if (Boredom <= 0)
            {
                Boredom = 0;
            }
            else if (Boredom >= 10)
            {
                Boredom = 10;
            }

            //Hunger
            if (Hunger >= 10)
            {
                Hunger = 10;
            }               
            else if (Hunger <= 0)
            {
                Hunger = 0;
            }
        }
        public void NameDisplay()
        {
            
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Color/Species: {Color} {Species}");
        }

        public virtual void Display()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Pet Status:");
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Color/Species: {Color} {Species}");
            Console.WriteLine($"Pet Type: { Type}");
            Console.WriteLine($"Health: {Health}");
            Console.WriteLine($"Boredom: {Boredom}");
            Console.WriteLine($"Hunger: {Hunger}");
        }
    }
    
}
