using CotizadorExpress.Models;
using CotizadorExpress.Views;
using System;

namespace CotizadorExpress.Presenters
{
    internal class Presenter
    {
        #region Properties
        private readonly IView _iView;
        private readonly Store _store;
        private readonly Seller _seller;
        private int _garmentIndex;
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

        public void SetElementToQuote()
        {
            _garmentIndex = 0;

            if (_iView.GarmentType == 0)
            {
                switch (_iView.ShirtSleeve)
                {
                    case 0 when _iView.ShirtNeck == 0 && _iView.Quality == 0:
                        _garmentIndex = 0;
                        break;
                    case 0 when _iView.ShirtNeck == 1 && _iView.Quality == 0:
                        _garmentIndex = 1;
                        break;
                    case 0 when _iView.ShirtNeck == 0 && _iView.Quality == 1:
                        _garmentIndex = 2;
                        break;
                    case 0 when _iView.ShirtNeck == 1 && _iView.Quality == 1:
                        _garmentIndex = 3;
                        break;

                    case 1 when _iView.ShirtNeck == 0 && _iView.Quality == 0:
                        _garmentIndex = 4;
                        break;
                    case 1 when _iView.ShirtNeck == 1 && _iView.Quality == 0:
                        _garmentIndex = 5;
                        break;
                    case 1 when _iView.ShirtNeck == 0 && _iView.Quality == 1:
                        _garmentIndex = 6;
                        break;
                    case 1 when _iView.ShirtNeck == 1 && _iView.Quality == 1:
                        _garmentIndex = 7;
                        break;
                }
            }
            else
            {
                switch (_iView.PantType)
                {
                    case 0 when _iView.Quality == 0:
                        _garmentIndex = 8;
                        break;
                    case 0 when _iView.Quality == 1:
                        _garmentIndex = 9;
                        break;
                    case 1 when _iView.Quality == 0:
                        _garmentIndex = 10;
                        break;
                    case 1 when _iView.Quality == 1:
                        _garmentIndex = 11;
                        break;
                }
            }

            _iView.Stock = _store.GetGarmentStock(_garmentIndex);
        }
        public bool Quote(int quantity, float price)
        {
            if (quantity == 0 || price == 0)
            {
                _iView.Message = "El valor o la cantidad no pueden ser 0";
                return false;
            }

            if (_iView.Stock >= quantity)
            {
                float result = _store.GetQuotedPrice(_garmentIndex, quantity, price);

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
