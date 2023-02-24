namespace CotizadorExpress.Models
{
    internal abstract class Garment
    {
        #region Properties
        protected enum EQuality { Standard, Premium }
        protected EQuality Quality = EQuality.Standard;
        protected float UnitaryPrice { get; set; }
        protected float QuotedPrice { get; set; }
        public int Stock { get; set; }
        #endregion

        protected void ModifyPrice()
        {
            if (Quality == EQuality.Premium)
            {
                QuotedPrice += QuotedPrice * 0.3f;
            }
        }

        #region AbstractMethods
        public abstract float FinalPrice(int quotedQuantity, float unitaryPrice);
        protected abstract void SetQuantity();
        #endregion
    }
}
