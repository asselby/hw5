/*	Реализовать не менее пяти закрытых полей(различных типов), представляющих основные характеристики рассматриваемого класса.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class Car
    {
        private double speed;
        private Color color;
        private int yearOfIssue;
        public static string name;
        public static string kindOfModel;

        static Car()
        {
            name = "";
            kindOfModel = "";
        }
        public Car()
        { }

        public Car(double speed, Color color, int yearOfIssue)
        {
            this.speed = speed;
            this.color = color;
            this.yearOfIssue = yearOfIssue;
        }

        public Car(double speed, Color color)
        {
            this.speed = speed;
            this.color = color;
        }

        public static void SetName(string anotherName)
        {
            name = anotherName;
        }

        public static string GetName()
        {
            return name;
        }

        public static string GetKindOfModel()
        {
            return kindOfModel;
        }

        public static void SetKindOfModel(string newKindOfModel)
        {
            kindOfModel = newKindOfModel;
        }

        public double Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public int AYear
        {
            get { return yearOfIssue; }
            set { yearOfIssue = value; }
        }

        public void ArrayOfOptions()
        {
            object[] optionsArray = new object[10];
            optionsArray[0] = kindOfModel;
            optionsArray[1] = speed;
            optionsArray[2] = color;
            optionsArray[3] = yearOfIssue;
            optionsArray[4] = name;


            Console.WriteLine("Характеристика машины:");
            Console.WriteLine("Модель -{0}", optionsArray[0]);
            Console.WriteLine("Скорость -{0}", optionsArray[1]);
            Console.WriteLine("Цвет -{0}", optionsArray[2]);
            Console.WriteLine("Год выпуска -{0}", optionsArray[3]);
            Console.WriteLine("Имя -{0}", optionsArray[4]);
        }
    }
}
