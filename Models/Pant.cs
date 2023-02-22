using System.Diagnostics;

namespace CotizadorExpress.Models
{
    internal class Pant : Garment
    {
        public enum EPantType { Normal, Skinny }
        private EPantType PantType;

        public Pant(){}
        public Pant(int pantType, int quality)
        {
            PantType = (EPantType)pantType;
            Quality = (EQuality)quality;

            SetQuantity();
        }
        private void SetQuantity()
        {
            Stock = PantType == EPantType.Skinny ? 750 : 250;
        }
        public override float FinalPrice(int quotedQuantity, float unitaryPrice)
        {
            UnitaryPrice = unitaryPrice;
            QuotedPrice = unitaryPrice;

            if (PantType == EPantType.Skinny)
            {
                QuotedPrice -= UnitaryPrice * 0.12f;
            }

            CalculatePrice();

            return QuotedPrice;
        }
    }
}
