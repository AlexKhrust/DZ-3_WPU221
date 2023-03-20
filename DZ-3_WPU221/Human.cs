using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DZ_3_WPU221
{
    class Human
    {
        public string _firstName = "Vasya";
        public string _lastName = "Lobov";
        public int _age = 18;

        public Human() { }
        public Human (string firstName, string lastName, int age)
        {
            _firstName = firstName;
            _lastName = lastName;
            _age = age;
        }
            
        public void Print() 
        {
            WriteLine($"Имя: {_firstName}\nФамилия: {_lastName}\nВозраст: {_age}\n");
        }

        public override string ToString()
        {
            return _firstName + " " + _lastName;
        }
    }

    class Warhammer : Human
    {
        private string _fraction = "The imperium of humanity";
        private string _patron = "Emperor";

        public Warhammer() { }
        public Warhammer(string firstName, string lastName, int age, string Fraction, string Patron) : base (firstName, lastName, age)
        { 
            _fraction = Fraction;
            _patron = Patron;
        }
        public new void Print()
        {
            WriteLine($"Имя: {_firstName}\nФамилия: {_lastName}\nВозраст: {_age}\nФракция: {_fraction}\nПокровитель: {_patron}\n");
        }

        public override string ToString()
        {
            return _firstName + " " + _lastName + " имеет покровителя "+_patron;
        }
    }

    class MiddleEarth : Human
    {
        private string _homeland = "Mordor";
        private string _race = "Orc";

        public MiddleEarth() { }
        public MiddleEarth (string firstName, string lastName, int age, string homeland, string race) : base (firstName, lastName, age)
        {
            _homeland = homeland;
            _race = race;
        }

        public new void Print()
        {
            WriteLine($"Имя: {_firstName}\nФамилия: {_lastName}\nВозраст: {_age}\nРодина: {_homeland}\nРасовая принадлежность: {_race}\n");
        }

        public override string ToString()
        {
            return _race + " " + _firstName + " " + _lastName + " родом из  " + _homeland;
        }
    }



    internal class Human1
    {
        static void Main(string[] args)
        {
            Human human1 = new Human("Stive", "Jobs", 23); //проверка базового класса
            human1.Print();
            string Test1 = human1.ToString(); //проверка переопределенного метода ToString() базового класса
            WriteLine(Test1+"\n");

            Warhammer human2 = new Warhammer("Victim", "Darius", 59, "The imperium of humanity", "Emperor");
            human2.Print();
            string Test2 = human2.ToString(); //проверка переопределенного метода ToString() производного класса
            WriteLine(Test2 + "\n");

            MiddleEarth notHuman = new MiddleEarth("Took", "Peregrin", 125, "Shire", "Hobbit");
            notHuman.Print();
            string Test3 = notHuman.ToString();
            WriteLine(Test3 + "\n");


        }
    }
}
