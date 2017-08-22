
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Car newCar = new Car(180, Color.blue, 2010);
            Car.SetName("Angelina");
            Car.SetKindOfModel("Niva");
            newCar.ArrayOfOptions();
            Console.ReadLine();
         }
    }
}
