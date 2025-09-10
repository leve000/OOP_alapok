using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace idk
{
    public class Szemely
    {
        string nev;
        int kor;

        public string Nev
        {
            get { return nev; }
            set { nev = value; }
        }

        /*
        public Szemely(string Nev, int Kor)
        {
            nev = Nev;
            kor = Kor;
        }

        public string Kiir()
        {
            return $"A tanuló neve: {nev} és {kor} éves.";
        }
        */
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Szemely tanulo1 = new Szemely();
            tanulo1.Nev = "Gábor";
            tanulo1.kor="25";
            Console.WriteLine(tanulo1.Nev);
            /*
            Szemely tanulo1 = new Szemely("Peti", 34);
            Console.WriteLine(tanulo1.Kiir());

            Szemely tanulo2 = new Szemely("Jani", 38);
            Console.WriteLine(tanulo2.Kiir());
            */
        }
    }
}