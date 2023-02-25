namespace CotizadorExpress.Views
{
    public interface IView
    {
        // Store
        string StoreName { get; set; }
        string StoreAddress { get; set; }

        // Seller
        string SellerName { get; set; }
        string SellerLastName { get; set; }
        string SellerId { get; set; }

        // General
        string Message { get; set; }
        int Stock { get; set; }
        string Quantity { get; }
        string Price { get; }
        int Quality { get; }

        int GarmentType { get; set; }
        // Shirt
        int ShirtSleeve { get; set; }
        int ShirtNeck { get; set; }

        // Pant
        int PantType { get; set; }

        void UpdateGarmentElement();
    }
}
