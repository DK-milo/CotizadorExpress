namespace CotizadorExpress.Models
{
    internal class Shirt : Garment
    {
        public enum ESleeve { Short, Long }
        private ESleeve Sleeve;
        public enum ENeck { Normal, Mao }
        private ENeck Neck;

        public Shirt(){ }
        public Shirt(int sleeve, int neck, int quality)
        {
            Sleeve = (ESleeve)sleeve;
            Neck = (ENeck)neck;
            Quality = (EQuality)quality;
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
        public override float FinalPrice(int quotedQuantity, float unitaryPrice)
        {
            UnitaryPrice = unitaryPrice;
            QuotedPrice = unitaryPrice;

            if (Sleeve == ESleeve.Short)
            {
                QuotedPrice -= UnitaryPrice * 0.1f;
            }

            if (Neck == ENeck.Mao)
            {
                QuotedPrice += UnitaryPrice * 0.03f;
            }

            CalculatePrice();

            return QuotedPrice * quotedQuantity;
        }
    }
}
