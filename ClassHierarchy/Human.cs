using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHierarchy
{
    // Класс Human - описывает человека
    internal class Human
    {
        protected string name;
        protected string surname;
        protected bool sex; // Пол: true - женский, false - мужской

        public Human(string _name, string _surname, bool _sex)
        {
            name = _name;
            surname = _surname;
            sex = _sex;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public bool Sex
        {
            get { return sex; }
            set { sex = value; }
        }

        public void Print()
        {
            Console.WriteLine("name: {0}", name);
            Console.WriteLine("surname: {0}", surname);
            if (sex) 
                Console.WriteLine("sex: Female");
            else 
                Console.WriteLine("sex: Male");
        }
    }
}
