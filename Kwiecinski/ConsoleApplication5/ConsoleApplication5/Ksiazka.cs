using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Książka : Pozycja
    {
        private int liczbaStron;

        public Autor autor; // tu ma być obiekt klasy Autor

        //konstruktor domyślny (warto dodać tworzenie pola autor jako obiektu Autor)
        public Książka()
        {
            autor = new Autor();
        }

        
        //konstruktor parametryczny n
        public Książka(string imie, string nazwisko, string tytul, int id, string wydawnictwo, int rokWydania, int liczbaStron)
            : base(tytul, id, wydawnictwo, rokWydania)
        {
            this.liczbaStron = liczbaStron;
            autor = new Autor(imie, nazwisko);
        }

        //metoda na wypisanie
        public override void WypiszInfo()
        {
            Console.WriteLine("Tytuł: {0}", tytul);
            Console.WriteLine("Autor: {0}", autor.PobierzAutora());
            Console.WriteLine("Nr katalogowy: {0}", id);
            Console.WriteLine("Wydawnictwo: {0}", wydawnictwo);
            Console.WriteLine("Rok wydaniwa: {0}", rokWydania);
            Console.WriteLine("Liczba stron: {0}", liczbaStron);
        }
       

        
    
    }
}
