using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateOOP
{
    internal class Appartamento : Immobile
    {
        public int NumeroVani {  get; set; }
        public int NumeroBagni { get; set; }        
        public Appartamento() { }
        public Appartamento(int Vani, int Bagni)
        {
            NumeroVani = Vani;
            NumeroBagni = Bagni;
        }

        public string PrintAppartamento()
        {
            return $"Appartamento ID: {UniqueKey}" +
                $"\nIndirizzo: {Address}" +
                $"\nCap: {Cap}" +
                $"\nCitta': {Citta}" +
                $"\nSuperficie: {Area}" +
                $"\nNumero Vani: {NumeroVani}" +
                $"\nNumero Bagni: {NumeroBagni}";
        }
    }
}
