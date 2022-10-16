using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klase_I_Objekti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zrakoplov x380 = new Zrakoplov("Airbus", 2000, 6000);
            Zrakoplov C162 = new Zrakoplov("Cessna Skycatcher", 75, 870);
            Zrakoplov PC21 = new Zrakoplov("Pilatus", 1200, 1333);

            Console.WriteLine("x380");
            Console.WriteLine(x380.ToString());

            Console.WriteLine("\r\nC162");
            Console.WriteLine(C162.ToString());

            Console.WriteLine("\r\nPC-21");
            Console.WriteLine(PC21.ToString());

            Console.ReadKey();
        }
        class Zrakoplov
        {
            private string Naziv;
            private int SnagaMotora, DosegLeta;

            public override string ToString()
            {
                string ispis = "Naziv: " + this.Naziv
                + "\r\nSnaga Motora: " + this.SnagaMotora + "kW"
                + "\r\nDoseg leta: " + this.DosegLeta + "Km";

                return ispis;
            }

            public Zrakoplov(string naziv, int snagaMotora, int dosegLeta)
            {
                this.Naziv = naziv;
                this.SnagaMotora = snagaMotora;
                this.DosegLeta = dosegLeta;
            }
        }
    }
}
