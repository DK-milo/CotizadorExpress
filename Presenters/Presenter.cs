using CotizadorExpress.Models;
using CotizadorExpress.Views;
using System;
using System.Collections.Generic;

namespace CotizadorExpress.Presenters
{
    internal class Presenter
    {
        #region Properties
        private readonly IView _iView;
        private readonly Store _store;
        private readonly Seller _seller;
        #endregion

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

        public int GetElementStock()
        {
            if (_iView.GarmentType == 0)
            {
                _store.Garments[0] = new Shirt(_iView.ShirtSleeve, _iView.ShirtNeck, _iView.Quality);
            }
            else
            {
                _store.Garments[1] = new Pant(_iView.PantType, _iView.Quality);
            }

            return _store.GetStock(_iView.GarmentType);
        }

        public bool Quote(int quantity, float price)
        {
            if (quantity == 0 || price == 0)
            {
                _iView.Message = "El valor o la cantidad no pueden ser 0";
                return false;
            }

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

                _iView.Message = $"${result}";
                return true;
            }

            _iView.Message = "Inventario insuficiente";
            return false;
        }
        public bool PrintQuotes()
        {
            if (_seller.QuotesHistory.Count > 0)
            {
                _iView.Message = _seller.PrintQuotes();
                return true;
            }

            _iView.Message = "No hay cotizaciones realizadas";
            return false;
        }
    }
}
