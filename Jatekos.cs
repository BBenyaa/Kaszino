using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaszinó
{
   

   

    public class Jatekos
    {
        private string nev;
        private int zseton;

        public Jatekos(string nev, int kezdoZseton)
        {
            this.nev = nev;
            this.zseton = kezdoZseton;
        }

        public string GetNev()
        {
            return nev;
        }

        public int GetZseton()
        {
            return zseton;
        }

        public void NovelZseton(int osszeg)
        {
            zseton += osszeg;
        }

        public void CsokkentZseton(int osszeg)
        {
            zseton -= osszeg;
        }


    }

}
