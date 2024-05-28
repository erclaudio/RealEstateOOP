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
            Agenzia CompraEasyAge = new Agenzia("CompraEasy");
            CompraEasyAge.AddImmobile(box1);
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
