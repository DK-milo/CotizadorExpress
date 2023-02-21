namespace CotizadorExpress.Models
{
    internal class Pant : Garment
    {
        public enum EPantType { Normal, Skinny }
        private EPantType PantType;

        public Pant(EPantType pantType, EQuality quality, float price)
        {
            Quality = quality;
            PantType = pantType;
            BasePrice = price;
            FinalPrice = price;

            SetQuantity();
        }
        private void SetQuantity()
        {
            Stock = PantType == EPantType.Skinny ? 750 : 250;
        }
        public override float Price()
        {
            if (PantType == EPantType.Skinny)
            {
                FinalPrice -= BasePrice * 0.12f;
            }

            CalculatePrice();

            return FinalPrice;
        }
    }
}
