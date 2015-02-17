using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Customer
{
    class Payment
    {
        public Payment(string productName, decimal price)
        {
            ProductName = productName;
            Price = price;
        }

        public string ProductName { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return string.Format("ProductName: {0}, Price: {1}", ProductName, Price);
        }
    }
}
