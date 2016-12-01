using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Autor : Osoba
    {
        private string narodowosc; //narodowosc jako int?

        public Autor()
        {
        }

        //konstruktor z 2 parametrami (bez narodowosci) 
        public Autor(string imie, string nazwisko)
            : base(imie, nazwisko)
        {
            narodowosc = "Polska";
        }

        public string PobierzAutora()
        {
            return imie + " " + nazwisko;
        }
    }
}
