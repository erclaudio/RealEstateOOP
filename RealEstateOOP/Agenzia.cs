using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateOOP
{
    internal class Agenzia
    {
        public string nome { get; set; }
        public List<Immobile> Immobili { get; set; }
        public Agenzia()
        {

        }
        public Agenzia(string nome)
        {
            this.nome = nome;
            this.Immobili = new List<Immobile>();
        }

        public void AddImmobile(Immobile immobile)
        {
            this.Immobili.Add(immobile);
        }
        public Immobile SearchImmobili(int id)
        {
            return this.Immobili.Find(p=>p.UniqueKey == id);
        }
    }
}
