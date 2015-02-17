using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Customer
{
    static class TestCustomer
    {
        static void Main(string[] args)
        {
            Payment tv = new Payment("Philips", 199m);
            Payment oven = new Payment("Rahovets", 220m);
            Payment mixer = new Payment("Rowenta", 100m);

            Customer peshoCustomer = new Customer("Pesho","Ivanov", "Peshev", 8912122345, "Orehova Gora 9", "+3598382382", "pesho@dir.bg", new List<Payment>() {tv, oven},CustomerType.Regular );
            Customer peshoCustomerNew = new Customer("Pesho", "Ivanov", "Peshev", 8912122345, "Orehova Gora 9", "+3598382382", "pesho@dir.bg", new List<Payment>() { mixer }, CustomerType.Onetime);
            Customer goshoCustomer = new Customer("Gosho", "Petrov", "Peshev", 3212123243, "Orehova Gora 8", "+3594342382", "gosho@dir.bg", new List<Payment>() { tv }, CustomerType.Onetime);
            
            Console.WriteLine(peshoCustomer);
            Console.WriteLine(peshoCustomerNew);
            Console.WriteLine(goshoCustomer);

            var clonedPesho = peshoCustomer.Clone();
            Console.WriteLine(clonedPesho);
            peshoCustomer.PaymentsList.Add(mixer);
            Console.WriteLine("changed");
            Console.WriteLine(peshoCustomer);
            Console.WriteLine(clonedPesho);

            Console.WriteLine(peshoCustomer.Equals(clonedPesho));
            Console.WriteLine(peshoCustomer.Equals(peshoCustomerNew));

            Console.WriteLine(peshoCustomer.CompareTo(goshoCustomer));
            Console.WriteLine(peshoCustomerNew.CompareTo(peshoCustomer));

            Console.WriteLine(peshoCustomer.GetHashCode());
        }
    }
}