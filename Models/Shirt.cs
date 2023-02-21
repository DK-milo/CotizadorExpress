namespace CotizadorExpress.Models
{
    internal class Shirt : Garment
    {
        public enum ESleeve { Short, Long }
        private ESleeve Sleeve;
        public enum ENeck { Normal, Mao }
        private ENeck Neck;

        public Shirt(ESleeve sleeve, ENeck neck, EQuality quality, float price)
        {
            Sleeve = sleeve;
            Neck = neck;
            Quality = quality;
            BasePrice = price;
            FinalPrice = price;

            SetQuantity();
        }
        private void SetQuantity()
        {
            switch (Sleeve)
            {
                case ESleeve.Short when Neck == ENeck.Mao:
                    Stock = 100;
                    break;
                case ESleeve.Short when Neck == ENeck.Normal:
                    Stock = 150;
                    break;
                case ESleeve.Long when Neck == ENeck.Mao:
                    Stock = 75;
                    break;
                case ESleeve.Long when Neck == ENeck.Normal:
                    Stock = 175;
                    break;
            }
        }
        public override float Price()
        {
            if (Sleeve == ESleeve.Short)
            {
                FinalPrice -= BasePrice * 0.1f;
            }

            if (Neck == ENeck.Mao)
            {
                FinalPrice += BasePrice * 0.03f;
            }

            CalculatePrice();

            return FinalPrice;
        }
    }
}
