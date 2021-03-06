using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwiatPracownikow
{
    [Serializable]
    public class Pielegniarka : Osoba
    {
        public Pielegniarka(string imie, string nazwisko, string pesel, string login, string haslo) : base(imie, nazwisko, pesel, login, haslo)
        {
            this.Stanowisko = "Pielegniarka";
            base.DodajPracownika(this);
        }
        public static void Modyfikuj(Osoba osoba, string imie, string nazwisko, string pesel, string login, string haslo)
        {
            osoba.Imie = imie;
            osoba.Nazwisko = nazwisko;
            osoba.Pesel = pesel;
            osoba.Login = login;
            osoba.Haslo = haslo;
        }
    }
}
