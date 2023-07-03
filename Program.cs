using System.Runtime.CompilerServices;
using template_csharp_virtual_pet;

internal class Program
{
    private static void Main(string[] args)
    {
        Pet myPet = new(5, "", "", "", 10, 5,"");
        Pet myPet1 = new(5, "", "", "", 10, 5, "");
        Pet myPet2 = new(5, "", "", "", 10, 5, "");
        Pet myPet3 = new(5, "", "", "", 10, 5, "");

        //To point at the different pets that are stored
        Pet pointer = new(5, "", "", "", 10, 5, "");
        Shelter shelter = new Shelter();


        shelter.AddPetToList(myPet);
        shelter.AddPetToList(myPet1);
        shelter.AddPetToList(myPet2);
        shelter.AddPetToList(myPet3);

        Console.Clear();
        Console.Title = "A Pet's Life by Blue Falcon Group";

        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\tWelcome to A Pet's Life");

        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("o()xxxx[{::::::::::::::::::::::::::::::::::>");
        Console.WriteLine("    Created by the Blue Falcon Group");
        Console.WriteLine("     | \r\n____________    __ -+-  ____________ \r\n\\_____     /   /_ \\ |   \\     _____/\r\n \\_____    \\____/  \\____/    _____/\r\n  \\_____                    _____/\r\n     \\___________  ___________/\r\n               /____\\");
        
        bool keepThinking = true;

        Thread.Sleep(1000);
        Console.Beep(440, 500);
        Console.Beep(440, 500);
        Console.Beep(440, 500);
        Console.Beep(349, 350);
        Console.Beep(523, 150);
        Console.Beep(440, 500);
        Console.Beep(349, 350);
        Console.Beep(523, 150);
        Console.Beep(440, 1000);
        Console.Beep(659, 500);
        Console.Beep(659, 500);
        Console.Beep(659, 500);
        Console.Beep(698, 350);
        Console.Beep(523, 150);
        Console.Beep(415, 500);
        Console.Beep(349, 350);
        Console.Beep(523, 150);
        Console.Beep(440, 1000);



        //Console.ForegroundColor= ConsoleColor.White;
        Console.Clear();

        while (keepThinking)
        { 
        
            Console.Clear();
            Console.WriteLine("\tA Pet's Life");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("----------------------------");

            //Displays Health
            //Console.WriteLine("What pet do you want to display?");
            //int a = Convert.ToInt32(Console.ReadLine());
            //petList[a].Display();
          
            //Menu
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("0 - Pick a pet to display: ");

            Console.WriteLine("1 - Choose and Customize Your Pet: ");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("2 - Feed Your Pet");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("3 - Play with Your Pet");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("4 - Take your Pet to the Vet");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("5 - View Status of All Pets");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("6 - Abandon Pet");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("7 - Play with all your pets");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("8 - Take all your pets to the vet");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("9 - Feed all your pets");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("10 - Quit Game and Abandon your Pet(s)");

            Console.ForegroundColor = ConsoleColor.White;
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "0":
                    Console.Title = "A Pet's Life by Blue Falcon Group";
                    Console.Clear();
                    pointer = shelter.GetPet();
                    pointer.Display();
                    break;
                case "1":
                    Console.Title = "A Pet's Life by Blue Falcon Group";
                    Console.Clear();
                    pointer = shelter.GetPet();
                    pointer.PetsNameAndSpecies();
                    pointer.Display();

                    break;

                case "2":
                    Console.Title = "A Pet's Life by Blue Falcon Group";
                    Console.Clear();
                    myPet.Feed();
                    break;

                case "3":
                    Console.Title = "A Pet's Life by Blue Falcon Group";
                    Console.Clear();
                    myPet.Play();
                    break;

                case "4":
                    Console.Title = "A Pet's Life by Blue Falcon Group";
                    Console.Clear();
                    myPet.Vet();
                    break;

                case "5":
                    Console.Title = "A Pet's Life by Blue Falcon Group";
                    Console.Clear();
                    shelter.ListPets();

                    break;
                case "6":
                    Console.Title = "A Pet's Life by Blue Falcon Group";
                    Console.Clear();
                    Console.WriteLine("Enter the number pet you want to remove. 0, 1, 2, 3");
                    shelter.NameDisplay();
                    int b = Convert.ToInt32(Console.ReadLine());
                    shelter.RemovePet(pointer);
                    break;
                case "7":
                    Console.Title = "A Pet's Life by Blue Falcon Group";
                    Console.Clear();
                    Console.WriteLine("Play with all pets");
                    shelter.AllPlay();
                    break;

                case "8":
                    Console.Title = "A Pet's Life by Blue Falcon Group";
                    Console.Clear();
                    Console.WriteLine("Take all your pets to the vet");
                    shelter.AllVet();

                    break;
                case "9":
                    Console.Title = "A Pet's Life by Blue Falcon Group";
                    Console.Clear();
                    Console.WriteLine("Feed all your pets");
                    shelter.AllFeed();

                    break;
                case "10":
                    Console.Title = "A Pet's Life by Blue Falcon Group";
                    Console.WriteLine("Thanks for abandoning your pet(s), monster...");
                    keepThinking = false;
                    break;

                default:
                    Console.Title = "A Pet's Life by Blue Falcon Group";
                    
                    break;

            }
            shelter.AllTick();
            Console.ReadLine();
        }

    }
}