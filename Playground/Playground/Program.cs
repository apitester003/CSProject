using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary;

namespace Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            MyObject myObject = new MyObject(3, 5);

            com.squareconnection.mylibrary.MyObject myNewObject = new com.squareconnection.mylibrary.MyObject(4, 5);

            myObject.number1 = 10;
            myObject.number2 = 15;
            Console.WriteLine(myObject.Calculate());
            Console.ReadLine();
        }
    }

    
}
