using System;
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

            //User Defined Variables -----------------------------------------
            PetStruct dog;
            dog.Type = PetType.Dog;
            dog.HasFur = true;
            dog.Legs = 4;

            PetClass duck = new PetClass();
            duck.Type = PetType.Duck;
            duck.HasFur = false;
            duck.Legs = 2;

            Console.Write("a " + dog.Type + " has " + dog.Legs + " Legs");
            Console.Write("a " + duck.Type + " has " + duck.Legs + " Legs");
            Console.ReadLine();
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
