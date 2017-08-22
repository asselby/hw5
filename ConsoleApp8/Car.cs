/*	Реализовать не менее пяти закрытых полей(различных типов), представляющих основные характеристики рассматриваемого класса.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public partial class Car
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

        public static string KindOfModel
        {
            get {return kindOfModel;}
            set { kindOfModel = value;}
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

       
    }
}
