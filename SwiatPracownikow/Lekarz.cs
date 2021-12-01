using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwiatPracownikow
{
    [Serializable]
    public class Lekarz : Osoba
    {
        public Lekarz(string imie, string nazwisko, string pesel, string login, string haslo, int specjalnosc, string pwz) : base(imie, nazwisko, pesel, login, haslo)
        {
            this.Specjalnosc = new Specjalnosc(specjalnosc);
            this.Pwz = pwz;
            this.Stanowisko = "Lekarz";
            base.DodajPracownika(this);
        }
        public static void Modyfikuj(Osoba osoba, string imie, string nazwisko, string pesel, string login, string haslo, int specjalnosc, string pwz)
        {
            osoba.Imie = imie;
            osoba.Nazwisko = nazwisko;
            osoba.Pesel = pesel;
            osoba.Login = login;
            osoba.Haslo = haslo;
            osoba.Specjalnosc = new Specjalnosc(specjalnosc);
            osoba.Pwz = pwz;
        }

    }
}
