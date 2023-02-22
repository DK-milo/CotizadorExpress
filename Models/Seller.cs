using System.Collections.Generic;

namespace CotizadorExpress.Models
{
    internal class Seller
    {
        public string Name { get; }
        public string LastName { get; }
        public int Id { get; }
        public List<Quote> QuotesHistory = new List<Quote>();
        public Seller(string name, string lastName, int id)
        {
            Name = name;
            LastName = lastName;
            Id = id;
        }
        public void SaveQuote(string garment, int quantity, float result)
        {
            Quote quote = new Quote(Id, garment, quantity, result);
            QuotesHistory.Add(quote);
        }
    }
}
