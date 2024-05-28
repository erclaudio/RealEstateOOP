using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateOOP
{
    internal class Immobile
    {
        public int UniqueKey { get; set; }
        public string Address { get; set; }
        public string Cap {  get; set; }
        public string Citta { get; set; }
        public int Area { get; set; }
        public Immobile() { }

        public Immobile(int uniqueKey, string address, string cap, string citta, int area)
        {
            UniqueKey = uniqueKey;
            Address = address;
            Cap = cap;
            Citta = citta;
            Area = area;
        }
        public override string ToString()
        {
            return $"ID: {UniqueKey}\n" +
                   $"Indirizzo: {Address}\n" +
                   $"Cap: {Cap}\n" +
                   $"Città: {Citta}\n" +
                   $"Superficie: {Area} mq";
        }
    }
}
