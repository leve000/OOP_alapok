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

        public int Kor
        {
            get { return kor; }
            set { kor = value; }
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

    public class Bankszamla
    {
        private int egyenleg;

        public int Egyenleg
                {
            get { return egyenleg; }
            set 
            { 
                if (value >= 0)
                    egyenleg = value;
                else
                    Console.WriteLine("Az egyenleg nem lehet negatív!");
            }
        }

        public void betesz()
        {
            
        }

        public void kivesz()
        {

        }
    }

    public class Hallgato : Szemely
    {
        
        private int neptunkod=12345;

        public void Kiir()
        {
            Nev=string.Empty;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Szemely tanulo1 = new Szemely();
            tanulo1.Nev = "Gábor";
            tanulo1.Kor=25;

            Console.WriteLine(tanulo1.Nev);
            Console.WriteLine(tanulo1.Kor);

            Bankszamla szamla1 = new Bankszamla();
            szamla1.Egyenleg = 1000;
            Console.WriteLine(szamla1.Egyenleg);
            /*
            Szemely tanulo1 = new Szemely("Peti", 34);
            Console.WriteLine(tanulo1.Kiir());

            Szemely tanulo2 = new Szemely("Jani", 38);
            Console.WriteLine(tanulo2.Kiir());
            */
        }
    }
}