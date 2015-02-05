using System;
using Multimedia_Shop.Interfaces;

namespace Multimedia_Shop.Models
{
    class Sale : ISaleable
    {
        private DateTime saleDate;
        private Item saleItem;
        public Item SaleItem
        {
            get { return this.saleItem; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Item being saled cannot be missing!");
                }
                this.saleItem = value;
            }
        }

        public DateTime SaleDate { get; set; }

        public Sale(Item saleItem, DateTime saleDate)
        {
            this.SaleItem = saleItem;
            this.SaleDate = saleDate;
        }

        public Sale(Item saleItem) : this(saleItem, DateTime.Now) { }
    }
}
