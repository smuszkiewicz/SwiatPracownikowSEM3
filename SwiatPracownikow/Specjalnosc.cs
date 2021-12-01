using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwiatPracownikow
{
    [Serializable]
    public class Specjalnosc
    {
        private string specjal;
        private int s;
        public Specjalnosc(int n)
        {
            if (n == 0) 
            {
                this.specjal = "kardiolog";
                this.s = n;
            }
            else if (n == 1)
            {
                this.specjal = "urolog";
                this.s = n;
            }
            else if (n == 2)
            {
                this.specjal = "neurolog";
                this.s = n;
            }
            else if (n == 3)
            {
                this.specjal = "laryngolog";
                this.s = n;
            }
        }

        public string Specjal { get => specjal; set => specjal = value; }
        public int S { get => s; set => s = value; }


    }
}
