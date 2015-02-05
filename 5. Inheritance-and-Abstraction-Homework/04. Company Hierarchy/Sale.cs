using System;


namespace _04.Company_Hierarchy
{
    class Sale
    {
        public Sale(string productName, DateTime date, decimal price)
        {
            this.Date = date;
            this.Price = price;
            this.ProductName = productName;
        }
        public string ProductName { get; set; }
        public DateTime Date { get; set; }
        public decimal Price { get; set; }
    }
}
