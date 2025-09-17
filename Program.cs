using System;
using System.Collections.Generic;
using System.Globalization;
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
        private string netpunKod;

        public string NetpunKod
        {
            get { return netpunKod; }
            set
            {
                if (value.Length <= 6) netpunKod = value;
                else Console.WriteLine("Nem megfelelő hosszúság!");
            }
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

            List<Hallgato> hallgatok = new List<Hallgato>();
            for (int i = 0; i < 2; i++)
            {
                Hallgato hallgato = new Hallgato();
                Console.WriteLine($"Kérem a(z) {i + 1}. hallgató nevét: ");
                hallgato.Nev = Console.ReadLine();
                Console.WriteLine($"Kérem az életkorát is: ");
                hallgato.Kor = int.Parse(Console.ReadLine());
                Console.WriteLine($"Kérem az netpunkódját is: ");
                hallgato.NetpunKod = Console.ReadLine();
                hallgatok.Add(hallgato);
            }

            Console.WriteLine();
            Console.WriteLine("Hallgatók neve:");

            foreach (var item in hallgatok)
            {
                Console.WriteLine(item.Nev);
            }
        }
    }
}