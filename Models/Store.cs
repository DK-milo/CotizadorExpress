using System.Collections.Generic;

namespace CotizadorExpress.Models
{
    internal class Store
    {
        #region Properties
        public string Name { get; }
        public string Address { get; }
        private List<Garment> Garments { get; }
        #endregion

        public Store(string name, string address)
        {
            Name = name;
            Address = address;
            Garments = new List<Garment>
            {
                new Shirt(0, 0, 0),
                new Shirt(0, 1, 0),
                new Shirt(0, 0, 1),
                new Shirt(0, 1, 1),

                new Shirt(1, 0, 0),
                new Shirt(1, 1, 0),
                new Shirt(1, 0, 1),
                new Shirt(1, 1, 1),

                new Pant(0,0),
                new Pant(0,1),
                new Pant(1,0),
                new Pant(1,1),
            };
        }
        public int GetGarmentStock(int index)
        {
            return Garments[index].Stock;
        }
        public float GetQuotedPrice(int garmentType, int quantity, float price)
        {
            return Garments[garmentType].FinalPrice(quantity, price);
        }
    }
}
