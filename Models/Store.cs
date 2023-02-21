using System.Collections.Generic;

namespace CotizadorExpress.Models
{
    internal class Store
    {
        public string Name { get; }
        public string Address { get; }
        public List<Garment> Garments { get;}

        public Store(string name, string address)
        {
            Name = name;
            Address = address;
            Garments = new List<Garment>();
        }
    }
}
