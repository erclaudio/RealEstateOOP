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
        public override string ToString()
        {
            return base.ToString() + $"\nSuperficie Giardino: {GiardinoDim}";
        }
    }
}
