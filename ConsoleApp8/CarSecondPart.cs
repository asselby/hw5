using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public partial  class Car
    {
        public void ArrayOfOptions()
        {
            object[] optionsArray = new object[10];
            optionsArray[0] = kindOfModel;
            optionsArray[1] = speed;
            optionsArray[2] = color;
            optionsArray[3] = yearOfIssue;
            optionsArray[4] = name;


            Console.WriteLine("Характеристика машины:");
            Console.WriteLine("Модель - {0}", optionsArray[0]);
            Console.WriteLine("Скорость - {0}", optionsArray[1]);
            Console.WriteLine("Цвет - {0}", optionsArray[2]);
            Console.WriteLine("Год выпуска - {0}", optionsArray[3]);
            Console.WriteLine("Имя - {0}", optionsArray[4]);
        }
    }
}
