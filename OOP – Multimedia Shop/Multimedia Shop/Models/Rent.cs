using System;
using Multimedia_Shop.Interfaces;

namespace Multimedia_Shop.Models
{
    class Rent : IRentable
    {
        private Item renItem;

        public Item RentItem
        {
            get { return this.renItem; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Item being rented cannot be missing!");
                }
                this.renItem = value;
            }
        }

        public RentState RentState
        {
            get
            {
                if (this.ReturnDate > DateTime.MinValue)
                {
                    return RentState.Returned;
                }
                else if (DateTime.Now > this.Deadline)
                {
                    return RentState.Overdue;
                }
                else
                {
                    return RentState.Pending;
                }
            }
 
        }        public DateTime RentDate { get; set; }
        public DateTime Deadline { get; set; }
        public DateTime ReturnDate { get; set; }

        public decimal RentFine
        {
            get { return (this.ReturnDate - this.Deadline).Days * (0.01m * this.RentItem.Price); }
        }

        public Rent(Item rentItem, DateTime rentDate, DateTime deadline)
        {
            this.RentItem = rentItem;
            this.RentDate = rentDate;
            this.Deadline = deadline;

        }
        public Rent(Item rentItem, DateTime rentDate) : this(rentItem, rentDate, rentDate.AddDays(30)) { }
        public Rent(Item rentItem) : this(rentItem, DateTime.Now, DateTime.Now.AddDays(30)) { }

        public void ReturnItem()
        {
            this.ReturnDate = DateTime.Now;
        }

        public decimal CalculateRentFIne(DateTime RentDate, DateTime Deadline, DateTime ReturnDate)
        {
            return RentFine;
        }
    }
}
