using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {

        static void MultipleLegs(PetStruct petStruct, PetClass petClass)
        {
            petStruct.Legs = petStruct.Legs * 2;
            petClass.Legs = petClass.Legs * 2;

            Console.WriteLine("Internal Method - A " + petStruct.Type + " has " + petStruct.Legs + " Legs");
            Console.WriteLine("Internal Method - A " + petClass.Type + " has " + petClass.Legs + " Legs");
        }
        static void Main(string[] args)
        {
            int[] intArray = new int[5];
            string[] stringArray = new string[5];

            int[,] multiInt = new int[2, 3];

            List<string> listOfStrings = new List<string>();
            listOfStrings.Add("First String");            
            listOfStrings.Add("Third String");
            listOfStrings.Insert(1, "Second String");//Inserts the value in index 1
            listOfStrings.RemoveAt(2);//Removes the index 2 content
            listOfStrings.Sort();

            Dictionary<string, string> names = new Dictionary<string, string>();
            names.Add("first_name", "James");
            names.Add("last_name","Bond");           

            //PetStruct dog;
            PetStruct dog = new PetStruct();
            dog.Legs = 4;
            dog.Type = PetType.Dog;
            dog.HasFur = true;

            PetClass duck = new PetClass();
            duck.Legs = 2;
            duck.Type = PetType.Duck;
            duck.HasFur = false;

            Console.Write("A " + dog.Type + " has " + dog.Legs + " Legs");
            Console.Write("\nA " + duck.Type + " has " + duck.Legs + " Legs\n");

            MultipleLegs(dog, duck);

            Console.WriteLine("A " + dog.Type + " has " + dog.Legs + " Legs");
            Console.WriteLine("A " + duck.Type + " has " + duck.Legs + " Legs");
            Console.ReadLine();
        }
    }

    class PetClass
    {
        public int Legs;
        public PetType Type;
        public string Name;
        public bool HasFur;

    }

    struct PetStruct
    {
        public int Legs;
        public PetType Type;
        public string Name;
        public bool HasFur;
    }

    enum PetType
    {
        Dog,
        Duck
    }
}
