using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHierarchy
{
    // Класс ForeignCitizen - унаследован от класса Citizen.
    // Данный класс есть запечатанным - не может быть унаследован другим классом
    sealed class ForeignCitizen : Citizen
    {
        private string foreignPassport;
        private DateTime visaOpen;
        private DateTime visaClose;

        public ForeignCitizen(string _name, string _surname, bool _sex,
            string _password, string _address,
            string _foreignPassport, DateTime _visaOpen, DateTime _visaClose)
            : base(_name, _surname, _sex, _password, _address)
        {
            foreignPassport = _foreignPassport;
            visaOpen = _visaOpen;
            visaClose = _visaClose;
        }
        public string ForeignPassport
        {
            get { return foreignPassport; }
            set { foreignPassport = value; }
        }
        public DateTime VisaOpen
        {
            get { return visaOpen; }
            set { visaOpen = value; }
        }
        public DateTime VisaClose
        {
            get { return visaClose; }
            set { visaClose = value; }
        }
        public new void Print()
        {
            base.Print();
            Console.WriteLine("foreignPassport: {0}", ForeignPassport);
            Console.WriteLine("visaOpen: {0}", visaOpen);
            Console.WriteLine("visaClose: {0}", visaClose);
        }
    }
}
