using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template_csharp_virtual_pet
{
    public class Shelter
    {
        //field
        private List<Pet> petRoster = new List<Pet> ();

        //properties
        public List<Pet> PetRoster {get; set;}

        public Shelter()
        {
            PetRoster = new List<Pet>();
        }

        public void AddPetToList(Pet pet)
        {
            PetRoster.Add(pet);
        }

        public void ListPets()
        {
            Console.WriteLine("Pets in the shelter:");
            foreach (Pet pet in PetRoster)
            {
                pet.Display();
            }
        }

        public void RemovePet(Pet pet)
        {
            PetRoster.Remove(pet);
        }
        public void NameDisplay()
        {
            Console.WriteLine("Pets in the shelter:");
            foreach (Pet pet in PetRoster)
            {
                pet.NameDisplay();
            }
        }
        public void AllPlay()
        {
            foreach (Pet pet in PetRoster)
            {
                pet.Play();
            }
        }
        public void AllFeed()
        {
            foreach (Pet pet in PetRoster)
            {
                pet.Feed();
            }
        }
        public void AllVet()
        {
            foreach (Pet pet in PetRoster)
            {
                pet.Vet();
                
            }
        }
        public Pet GetPet()
        {
            Console.WriteLine("What slot would you like your pet to be in? 0,1,2 or 3?");
            int a = Convert.ToInt32(Console.ReadLine());
            return PetRoster[a];
        }
        public void AllTick()
        {
            foreach (Pet pet in PetRoster)
            {
                pet.Tick();

            }
        }
    }
}
