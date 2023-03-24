using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
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

    class TES : Human
    {
        private string _guild = "Warriors";
        private string _skill = "Two-handed weapon";

        public TES() { }
        public TES (string firstName, string lastName, int age, string guild, string skill) : base(firstName, lastName, age)
        {
            _guild = guild;
            _skill = skill;
        }

        public new void Print()
        {
            WriteLine($"Имя: {_firstName}\nФамилия: {_lastName}\nВозраст: {_age}\nГильдия: {_guild}\nГлавный навык: {_skill}\n");
        }

        public override string ToString()
        {
            return _firstName + " " + _lastName + " член гильдии  " + _guild + " с главным навыком " + _skill;
        }
    }

    class Concord : Human
    {
        private string _status = "Pirate";
        private string _shipName = "Dumbfounded";

        public Concord() { }
        public Concord (string firstName, string lastName, int age, string status, string shipName) : base(firstName, lastName, age)
        {
            _status = status;
            _shipName = shipName;
        }

        public new void Print()
        {
            WriteLine($"Имя: {_firstName}\nФамилия: {_lastName}\nВозраст: {_age}\nСтатус: {_status}\nИмя корабля: {_shipName}\n");
        }

        public override string ToString()
        {
            return _status + " " + _firstName + " " + _lastName + " капитан корабля  " + _shipName;
        }
    }

    class OurReality : Human
    {
        private string _country = "Russia";
        private string _activity = "Student";
        private string _religion = "Pasta monster";

        public OurReality() { }
        public OurReality(string firstName, string lastName, int age, string country, string activity, string religion) : base(firstName, lastName, age)
        {
            _country = country;
            _activity = activity;
            _religion = religion;

        }

        public new void Print()
        {
            WriteLine($"Имя: {_firstName}\nФамилия: {_lastName}\nВозраст: {_age}\nСтрана: {_country}\nВид деятельности: {_activity}\nРелигия: {_religion}\n");
        }

        public override string ToString()
        {
            return _activity + " " + _firstName + " " + _lastName + " проживает в " + _country + " верит в " + _religion;
        }

    }

    internal class Human1
    {
        static void Main(string[] args)
        {
            Human human1 = new Human("Stive", "Jobs", 23); //проверка базового класса
            human1.Print();
            string Test1 = human1.ToString(); //проверка переопределенного метода ToString() базового класса
            WriteLine(Test1 + "\n");

            Warhammer human2 = new Warhammer("Victim", "Darius", 59, "The imperium of humanity", "Emperor");
            human2.Print();
            string Test2 = human2.ToString(); //проверка переопределенного метода ToString() производного класса
            WriteLine(Test2 + "\n");

            MiddleEarth notHuman = new MiddleEarth("Took", "Peregrin", 125, "Shire", "Hobbit");
            notHuman.Print();
            string Test3 = notHuman.ToString();
            WriteLine(Test3 + "\n");

            TES danmer = new TES("Algus", "Septim", 41, "Guild of magicians", "Destruction");
            danmer.Print();
            string Test4 = danmer.ToString(); //проверка переопределенного метода ToString() производного класса
            WriteLine(Test4 + "\n");

            Concord citizen = new Concord("Jon", "Kampble", 68, "Trader", "Barracuda");
            citizen.Print();
            string Test5 = citizen.ToString(); //проверка переопределенного метода ToString() производного класса
            WriteLine(Test5 + "\n");

            OurReality man = new OurReality();
            man.Print();
            string Test6 = man.ToString(); //проверка переопределенного метода ToString() производного класса
            WriteLine(Test6 + "\n");
        }
    }
}
