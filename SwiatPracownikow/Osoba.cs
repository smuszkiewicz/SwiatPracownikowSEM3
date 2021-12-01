using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwiatPracownikow
{
    [Serializable]
    abstract public class Osoba
    {
        private static List<Osoba> listaPracownikow = new List<Osoba>();
        static int n = 0;
        private int index;
        private string imie;
        private string nazwisko;
        private string pesel;
        private string login;
        private string haslo;
        private string stanowisko;
        private Specjalnosc specjalnosc;
        private string pwz;

        protected Osoba(string imie, string nazwisko, string pesel, string login, string haslo)
        {
            foreach (Osoba osoba in ListaPracownikow)
            {
                if (login == osoba.Login)
                {
                    throw new Exception();
                }
            }
            this.Index = n;
            this.Imie = imie;
            this.Nazwisko = nazwisko;
            this.Pesel = pesel;
            this.Login = login;
            this.Haslo = haslo;
            n++;
        }

        public static List<Osoba> ListaPracownikow { get => listaPracownikow; set => listaPracownikow = value; }
        public int Index { get => index; set => index = value; }
        public string Imie { get => imie; set => imie = value; }
        public string Nazwisko { get => nazwisko; set => nazwisko = value; }
        public string Pesel { get => pesel; set => pesel = value; }
        public string Login { get => login; set => login = value; }
        public string Haslo { get => haslo; set => haslo = value; }
        public string Stanowisko { get => stanowisko; set => stanowisko = value; }
        public Specjalnosc Specjalnosc { get => specjalnosc; set => specjalnosc = value; }
        public string Pwz { get => pwz; set => pwz = value; }

        public void DodajPracownika(Osoba pracownik)
        {
            listaPracownikow.Add(pracownik);
        }
        public static void UsunPracownika(Osoba pracownik)
        {
            listaPracownikow.Remove(pracownik);
        }
        public override string ToString()
        {
            return String.Format("{3}. {0} {1} ({2})", this.Imie, this.Nazwisko, this.GetType().Name, this.Index);
        }
        public static string Logowanie(string login, string haslo)
        {
            foreach (Osoba pracownik in ListaPracownikow)
            {
                if (login == pracownik.Login)
                {
                    if (haslo == pracownik.Haslo)
                    {
                        return pracownik.GetType().Name;
                    }
                }
            }
            return "false";
        }
        
    }
}
