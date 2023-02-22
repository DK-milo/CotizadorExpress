using CotizadorExpress.Models;
using CotizadorExpress.Views;
using System;
using System.Collections.Generic;
using System.Globalization;
using static CotizadorExpress.Models.Garment;

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
        public string Quote(int quantity, float price)
        {
            if (GetElementStock() >= quantity)
            {
                float result = _store.Garments[_iView.GarmentType].FinalPrice(quantity, price);

                switch (_iView.GarmentType)
                {
                    case 0:
                        _seller.SaveQuote("Camisa", quantity, result);
                        break;
                    case 1:
                        _seller.SaveQuote("Pantalon", quantity, result);
                        break;
                }

                return $"${result}";
            }

            return "Inventario insuficiente";
        }
        public List<Quote> GetQuotes()
        {
            return _seller.QuotesHistory;
        }
        private void SetElementToQuote()
        {
            if (_iView.GarmentType == 0)
            {
                _store.Garments[0] = new Shirt(_iView.ShirtSleeve, _iView.ShirtNeck, _iView.Quality);
            }
            else
            {
                _store.Garments[1] = new Pant(_iView.PantType, _iView.Quality);
            }
        }
        public int GetElementStock()
        {
            SetElementToQuote();
            return _store.GetStock(_iView.GarmentType);
        }
    }
}
