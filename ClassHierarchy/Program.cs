using ClassHierarchy;
using System;

namespace DemoSplitFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Использование экземпляра класса Human
            Human hm = new Human("John", "Johnson", false);
            hm.Print();

            // 2. Использование экземпляра класса Citizen
            Citizen ct = new Citizen("Petr", "Petrenko", false, "A101ksdl233", "New City");
            Console.WriteLine("------------------------");
            ct.Print(); // вывести значение полей класса

            // 3. Использование экземпляра класса ForeignCitizen
            ForeignCitizen fc = new ForeignCitizen("Ivanov", "Ivan", false,
                "0230902ADK", "London", "023329032JJK",
                Convert.ToDateTime("02.02.2020"), Convert.ToDateTime("03.03.2085"));
            Console.WriteLine("------------------");
            fc.Print();
        }
    }
}