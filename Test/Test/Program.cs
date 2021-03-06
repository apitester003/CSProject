using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Everything begins from here
                //int num1 = 0;
                //int num2 = 0;
                //int answer = 0;

                //Console.WriteLine("Enter a Number");
                //string sNum = Console.ReadLine();

                //Console.WriteLine("Enter a Second Number");
                //string sNum2 = Console.ReadLine();

                //Int32.TryParse(sNum, out num1);
                //Int32.TryParse(sNum2, out num2);

                //answer = num1 + num2;
                //Console.WriteLine("The Answer is: " + answer);

            //Defining an array ---- Fixed Type & Fixed Length
                int[] intArray = new int[5];
                string[] populatedStringArray = new string[] { "Hello", "I", "am", "Sam" };

                int[,] multiIntArray = new int[2, 3];
                string[,] multiPopulatedStringArray = { { "Jammu & Kashmir", "Ladakh", "Punjab" }, { "Srinagar", "Leh", "Chandigarh"} };

            //Collections ------- Lists - Fixed Type & Variable Length (Numeric)
                List<String> listOfStrings = new List<String>();
                listOfStrings.Add("Hi");
                listOfStrings.Add("This");
                listOfStrings.Add("Is");
                listOfStrings.Add("Sam");

                listOfStrings.Insert(3, "Mr.");     //Inserts "Mr." before "Sam"
            
                listOfStrings.Remove("Hi");
                //Or
                listOfStrings.RemoveAt(0);          //Removes whatever is there at index 0

                listOfStrings.Sort();               //Ascending Sort

            //Collection -------- Dictionary - Fixed Type & Variable Length (Associative)
                Dictionary<string, string> names = new Dictionary<string, string>();
                names.Add("first_name", "Sam");
                names.Add("last_name", "Sahoo");
                names.Remove("last_name");

            //Collection -------- ArrayList - Variable Length & Variable Type
                ArrayList newArrayList = new ArrayList();
                newArrayList.Add("Ryan");

            //Collection -------- HashTable - Variable Length & Variable Type (Associative)
                Hashtable studentRecord = new Hashtable();
                studentRecord.Add("name", "Ryan");

            //Collection -------- SortedList - Variable Length & Variable Type (Associative)
                SortedList newSortedList = new SortedList();
                newSortedList.Add("Name", "Ryan");

            //Collection -------- Stack - Variable Length & Variable Type LIFO
            Stack bookStack = new Stack();
                bookStack.Push("Ryan");
                bookStack.Push("Rhodney");

            //Collection -------- Queue - Variable Length & Variable Type FIFO
                Queue ticketCounter = new Queue();
                ticketCounter.Enqueue("Ryan");
                ticketCounter.Enqueue("Ricky");

            

            //User Defined Variables -----------------------------------------
            PetStruct dog = new PetStruct();
            dog.Type = PetType.Dog;
            dog.HasFur = true;
            dog.Legs = 4;

            PetClass duck = new PetClass();
            duck.Type = PetType.Duck;
            duck.HasFur = false;
            duck.Legs = 2;

            Console.WriteLine("a " + dog.Type + " has " + dog.Legs + " Legs");
            Console.WriteLine("a " + duck.Type + " has " + duck.Legs + " Legs");

            MultipleLegs(dog, duck);

            //LINQ -----------------------------------------------------------

                //Create a List of type Petclass
                List<PetClass> pets = new List<PetClass>();
                pets.Add(new PetClass { 
                    HasFur=false, Legs=2, Name="Danny", Type=PetType.Duck
                });

                pets.Add(new PetClass { 
                    HasFur=true, Legs=4, Name="Tommy", Type=PetType.Dog
                });
                //1) USING LINQ STATEMENTS

                //Stores a list of results
                List<PetClass> results = (from p in pets
                                     where p.Type == PetType.Dog
                                     select p).ToList();

                //Gets a single result
                PetClass singleResult = (from sr in pets
                                               where sr.Name == "Pluto"
                                               select sr).FirstOrDefault();

                //2) USING LAMBDA QUERIES
                results = pets.Where(p => p.Type == PetType.Dog).ToList();

                singleResult = pets.FirstOrDefault(p => p.Name == "Pluto");

                

            Console.WriteLine("found " + results.Count + " Dogs");

            Console.ReadLine();
        }

        static void MultipleLegs(PetStruct petStruct, PetClass petClass)
        {
            petStruct.Legs = petStruct.Legs * 2;
            petClass.Legs = petClass.Legs * 2;

            Console.WriteLine("Internal Method - A " + petStruct.Type + " has " + petStruct.Legs + " Legs.");
            Console.WriteLine("Internal Method - A " + petClass.Type + " has " + petClass.Legs + " Legs.");
        }
    }

    class PetClass
    {
        public int Legs;
        public PetType Type;
        public string Name;
        public Boolean HasFur;
    }

    struct PetStruct
    {
        public int Legs;
        public PetType Type;
        public string Name;
        public Boolean HasFur;
    }

    enum PetType
    {
        Dog,
        Duck
    }
}
