using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateOOP
{
    internal class Box : Immobile
    {
        public int PostiAuto {  get; set; }
        public Box() { }
        public Box(int postiAuto)
        {
            PostiAuto = postiAuto;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nPosti Auto: {PostiAuto}";
        }
    }
}
