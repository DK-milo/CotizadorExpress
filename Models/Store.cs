using System.Collections.Generic;

namespace CotizadorExpress.Models
{
    internal class Store
    {
        public string Name { get; }
        public string Address { get; }
        public List<Garment> Garments { get; set; }
        public Store(string name, string address)
        {
            Name = name;
            Address = address;
            Garments = new List<Garment> {new Shirt(), new Pant()};
        }
        public int GetStock(int index)
        {
            return Garments[index].Stock;
        }
    }
}
