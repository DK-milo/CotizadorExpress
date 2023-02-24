using System.Collections.Generic;

namespace CotizadorExpress.Models
{
    internal class Seller
    {
        #region Properties
        public string Name { get; }
        public string LastName { get; }
        public int Id { get; }
        public List<Quote> QuotesHistory = new List<Quote>();
        #endregion

        public Seller(string name, string lastName, int id)
        {
            Name = name;
            LastName = lastName;
            Id = id;
        }

        public void SaveQuote(string garment, int quantity, float result)
        {
            Quote quote = new Quote(QuotesHistory.Count + 1, Id, garment, quantity, result);
            QuotesHistory.Add(quote);
        }

        public string PrintQuotes()
        {
            string data = "";

            foreach (Quote quote in QuotesHistory)
            {
                data += quote.PrintData();
            }
            return data;
        }
    }
}
