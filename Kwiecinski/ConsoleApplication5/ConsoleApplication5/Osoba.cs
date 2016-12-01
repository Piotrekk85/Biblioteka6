using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Osoba  //czemu tu klasa ma być prywatna?
    {
        protected string imie; //imie i nazwisko przechowywane jako int?
        protected string nazwisko;

        public Osoba()
        {
        }

        public Osoba(string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
        }

    }
}
