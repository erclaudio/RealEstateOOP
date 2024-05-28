using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateOOP
{
    internal class Villa : Appartamento
    {
        public int GiardinoDim {  get; set; }
        public Villa() { }
        public Villa(int giardinoDim)
        {
            GiardinoDim = giardinoDim;
        }
        public string PrintVilla()         
        {
                return $"Villa ID: {UniqueKey}" +
                    $"\nIndirizzo: {Address}" +
                    $"\nCap: {Cap}" +
                    $"\nCitta': {Citta}" +
                    $"\nSuperficie: {Area}" +
                    $"\nNumero Vani: {NumeroVani}" +
                    $"\nNumero Bagni: {NumeroBagni}"+
                    $"\nSuperficie Giardino: {GiardinoDim}";           
        }
    }
}
