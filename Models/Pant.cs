namespace CotizadorExpress.Models
{
    internal class Pant : Garment
    {
        #region Properties
        private enum EPantType { Normal, Skinny }
        private EPantType PantType;
        #endregion
        
        public Pant(){}
        public Pant(int pantType, int quality)
        {
            PantType = (EPantType)pantType;
            Quality = (EQuality)quality;

            SetQuantity();
        }

        #region Inherited Methods
        protected sealed override void SetQuantity()
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

            ModifyPrice();

            return QuotedPrice;
        }
        #endregion
    }
}
