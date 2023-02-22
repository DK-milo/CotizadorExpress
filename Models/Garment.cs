namespace CotizadorExpress.Models
{
    internal abstract class Garment
    {
        public enum EQuality { Standard, Premium }
        protected EQuality Quality = EQuality.Standard;
        public float UnitaryPrice { get; set; }
        protected float QuotedPrice { get; set; }
        public int Stock { get; set; }

        #region Methods
        protected void CalculatePrice()
        {
            if (Quality == EQuality.Premium)
            {
                QuotedPrice += UnitaryPrice * 0.3f;
            }
        }
        public abstract float FinalPrice(int quotedQuantity, float unitaryPrice);
        #endregion
    }
}
