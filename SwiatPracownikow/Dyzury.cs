using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwiatPracownikow
{
    [Serializable]
    public static class Dyzury
    {
        static private Osoba[,] planDyzurow = new Osoba[31,20];

        static public Osoba[,] PlanDyzurow { get => planDyzurow; set => planDyzurow = value; }

        static public bool DodajDyzur(Osoba osoba, int data)
        {
            if (osoba.GetType().Name == "Administrator")
            {
                return false;
            }
            int sprIle = 0;
            foreach (Osoba dyzur in Dyzury.planDyzurow)
            {
                if (osoba == dyzur)
                {
                    sprIle += 1;
                }
            }
            if (sprIle >= 10)
            {
                return false;
            }
            for (int i = 0; i < planDyzurow.GetLength(1); i++)
            {
                if (osoba.Stanowisko == "Lekarz")
                {
                    if (planDyzurow[data, i] != null)
                    {
                        if (planDyzurow[data, i].Stanowisko == "Lekarz")
                        {
                            if (planDyzurow[data, i].Specjalnosc == osoba.Specjalnosc)
                            {
                                return false;
                            }
                        }
                    }
                }
                if (data != 0)
                {
                    if (planDyzurow[data - 1, i] == osoba)
                    {
                        return false;
                    }
                }
                if (data != 30)
                {
                    if (planDyzurow[data + 1, i] == osoba)
                    {
                        return false;
                    }
                }
                if (planDyzurow[data, i] == osoba)
                {
                    return false;
                }
            }
            for (int i = 0; i < planDyzurow.GetLength(1); i++)
            {
                if (planDyzurow[data, i] == null)
                {
                    planDyzurow[data, i] = osoba;
                    return true;
                }
            }
            return false;
        }
        static public bool UsunDyzur(Osoba osoba, int data)
        {
            for (int i = 0; i < planDyzurow.GetLength(1); i++)
            {
                if (planDyzurow[data, i] == osoba)
                {
                    planDyzurow[data, i] = null;
                    return true;
                }
            }
            return false;
        }
        public static string ToString(int i)
        {
            string listaNazwisk = "";
            for (int j = 0; j < planDyzurow.GetLength(1); j++)
            {
                if (planDyzurow[i, j] != null)
                {
                    if (planDyzurow[i, j].GetType().Name == "Pielegniarka")
                    {
                        listaNazwisk = listaNazwisk + planDyzurow[i, j].Nazwisko + "(" + planDyzurow[i, j].Stanowisko.Substring(0, 1).ToUpper() + ")" + ", ";
                    }
                    else
                    {
                        listaNazwisk = listaNazwisk + planDyzurow[i, j].Nazwisko + "(" + planDyzurow[i, j].Specjalnosc.Specjal.Substring(0, 1).ToUpper() + ")" + ", ";
                    }
                }
            }
            return String.Format("{0}. {1}", (i + 1), listaNazwisk);
        }
    }
}
