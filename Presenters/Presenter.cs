using CotizadorExpress.Models;
using CotizadorExpress.Views;
using System;
using System.Collections.Generic;

namespace CotizadorExpress.Presenters
{
    internal class Presenter
    {
        private readonly IView _iView;
        private Store _store;
        private Seller _seller;

        public Presenter(IView view)
        {
            _iView = view;
            Random r = new Random();

            _store = new Store("El Gangazo", $"Calle: {r.Next(1, 100)}, Carrera: {r.Next(1, 100)}");
            _seller = new Seller("Pedro", "Peréz", r.Next(1, 9999));

            SetUiTexts();
        }
        private void SetUiTexts()
        {
            _iView.StoreName = _store.Name;
            _iView.StoreAddress = _store.Address;

            _iView.SellerName = _seller.Name;
            _iView.SellerLastName = _seller.LastName;
            _iView.SellerId = _seller.Id.ToString();
        }
        public float QuoteShirt(int shirtSleeve, int shirtNeck, int quality, int quantity, float price)
        {
            Shirt shirt = new Shirt((Shirt.ESleeve)shirtSleeve, (Shirt.ENeck)shirtNeck, (Garment.EQuality)quality, price);
            float result = shirt.Price() * quantity;

            Quote quote = new Quote(_seller.Id, "Camisa", quantity, result);
            _seller.QuotesHistory.Add(quote);

            return result;
        }
        public float QuotePant(int pantType, int quality, int quantity, float price)
        {
            Pant pant = new Pant((Pant.EPantType)pantType, (Garment.EQuality)quality, price);
            float result = pant.Price() * quantity;

            Quote quote = new Quote(_seller.Id, "Pantalón", quantity, result);
            _seller.QuotesHistory.Add(quote);

            return result;
        }
        public List<Quote> GetQuotes()
        {
            return _seller.QuotesHistory;
        }
    }
}
