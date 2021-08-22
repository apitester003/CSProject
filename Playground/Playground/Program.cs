using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            MyObject myObject = new MyObject();
            myObject.number1 = 10;
            myObject.number2 = 15;
            Console.WriteLine(myObject.Calculate());
            Console.ReadLine();
        }
    }

    class MyObject
    {
        public MyObject(int number1, int number2)       //Constructor
        {
            _number1 = number1;
            _number2 = number2;
        }

        int _number1 = 0; //these are Intenal variables, we dont need to get/set 
        int _number2 = 0; //these are Intenal variables, we dont need to get/set 
        int _number3 = 0; //these are Intenal variables, we dont need to get/set 
        //public int number1 { get; set; }
        public int number1
        {
            get
            {
               return _number1;
            }
            set
            {
                _number1 = value;
            }
        }
        //public int number2 { get; set; }
        public int number2
        {
            get
            {
                return _number2;
            }
            set
            {
                _number2 = value;
            }
        }

        public int number3
        {
            get
            {
                return _number1 + _number2;
            }
            set
            {
                _number3 = value;
            }
        }
        public int Calculate() {
            return number1 + number2;
        }

        public string MyMethod()
        {
            return "Some Value";
        }
    }
}
