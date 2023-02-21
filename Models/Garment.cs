namespace CotizadorExpress.Models
{
    internal abstract class Garment
    {
        public enum EQuality { Standard, Premium }
        protected EQuality Quality = EQuality.Standard;
        protected float BasePrice { get; set; }
        protected float FinalPrice { get; set; }
        public int Stock { get; set; }

        #region Methods
        protected void CalculatePrice()
        {
            if (Quality == EQuality.Premium)
            {
                FinalPrice += BasePrice * 0.3f;
            }
        }
        public abstract float Price();
        #endregion
    }
}
