using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box box1 = new Box
            {
                UniqueKey = 1,
                Address = "Via Ceppa Viola 11",
                Cap = "00146",
                Citta = "Verona",
                Area = 45,
                PostiAuto = 2
            };
            Villa villa1 = new Villa
            {
                UniqueKey = 2,
                Address = "Piazza Dei Ceppi Verdi 69",
                Cap = "00674",
                Citta = "Pisa",
                Area = 435,
                GiardinoDim = 893

            };
            Appartamento app1 = new Appartamento
            {
                UniqueKey = 3,
                Address = "Giardino Grigio 23",
                Cap = "00111",
                Citta = "Roma",
                Area = 123,
                NumeroVani = 4,
                NumeroBagni = 3
            };
            Agenzia CompraEasyAge = new Agenzia("CompraEasy");
            CompraEasyAge.AddImmobile(box1);
            CompraEasyAge.AddImmobile(villa1);
            CompraEasyAge.AddImmobile(app1);
            Console.WriteLine($"Benvenuto in {CompraEasyAge.nome}, inserisci la chiave di ricerca: ");
            int selection = int.Parse( Console.ReadLine() );
            Immobile immobile = CompraEasyAge.SearchImmobili(selection);
            if (immobile != null)
            {
                Console.WriteLine(immobile);
            }
            else
            {
                Console.WriteLine("Immobile non trovato.");
            }

            // Wait for user input before closing the console
            Console.ReadLine();
            Console.Read();

        }
    }
}
