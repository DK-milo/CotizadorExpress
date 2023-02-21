using System;
using System.Globalization;

namespace CotizadorExpress.Models
{
    internal class Quote
    {
        private int _id;
        private string _timeStamp;
        private int _sellerCode;
        private string _listedGarment;
        private int _garmentQuantity;
        private float _quoteResult;

        public Quote(int sellerCode, string garment, int quantity, float result)
        {
            _id = new Random().Next(1, 9999);
            _timeStamp = DateTime.Now.ToString(CultureInfo.InvariantCulture);
            _sellerCode = sellerCode;
            _listedGarment = garment;
            _garmentQuantity = quantity;
            _quoteResult = result;
        }
        public string PrintData()
        {
            return $"ID: {_id} \nFecha: {_timeStamp} \nID Vendedor: {_sellerCode} \nPrenda: {_listedGarment} \nCantidad: {_garmentQuantity} \nTotal: {_quoteResult}";
        }
    }
}
