using System;
using System.Collections.Generic;

namespace _01.Customer
{
    internal class Customer : ICloneable, IComparable<Customer>
    {
        public Customer(string firstName, string middleName, string lastName, long id, string address, string mobilePhone,
            string email, List<Payment> paymentsList, CustomerType customerType)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            Id = id;
            Address = address;
            MobilePhone = mobilePhone;
            Email = email;
            PaymentsList = paymentsList;
            CustomerType = customerType;
        }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public long Id { get; set; }
        public string Address { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public List<Payment> PaymentsList { get; set; }
        public CustomerType CustomerType { get; set; }


        public override string ToString()
        {
            return
                string.Format(
                    "FirstName: {0}, MiddleName: {1}, LastName: {2}, ID: {3}, Address: {4}, MobilePhone: {5}, Email: {6}, PaymentsList: {7}, CustomerType: {8}\n\r",
                    FirstName, MiddleName, LastName, Id, Address, MobilePhone, Email, String.Join(" , ", PaymentsList), CustomerType);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(Customer)) return false;
            return Equals((Customer)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (FirstName != null ? FirstName.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (MiddleName != null ? MiddleName.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (LastName != null ? LastName.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (int)Id;
                hashCode = (hashCode * 397) ^ (Address != null ? Address.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (MobilePhone != null ? MobilePhone.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Email != null ? Email.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (PaymentsList != null ? PaymentsList.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (int)CustomerType;
                return hashCode;
            }
        }

        protected bool Equals(Customer other)
        {
            return string.Equals(FirstName, other.FirstName) && string.Equals(MiddleName, other.MiddleName) &&
                   string.Equals(LastName, other.LastName) && Id == other.Id && string.Equals(Address, other.Address) &&
                   string.Equals(MobilePhone, other.MobilePhone) && string.Equals(Email, other.Email) &&
                   Equals(PaymentsList, other.PaymentsList) && CustomerType == other.CustomerType;
        }

        public static bool operator ==(Customer left, Customer right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Customer left, Customer right)
        {
            return !Equals(left, right);
        }

        public object Clone()
        {
            return new Customer(
                this.FirstName, this.MiddleName, this.LastName, this.Id, this.Address, this.MobilePhone, this.Email,
                new List<Payment>(this.PaymentsList), this.CustomerType);
        }

        public int CompareTo(Customer other)
        {
            return String.Join("", this.FirstName, this.MiddleName, this.LastName) == String.Join("", other.FirstName, other.MiddleName, other.LastName) ?  this.Id.CompareTo(other.Id):  this.FirstName.CompareTo(other.FirstName);
        }
    }
}