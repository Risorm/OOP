namespace _02.Bank_of_Kurtovo_Konare
{
    public interface IAccountable
    {
        Customer Customer { get; set; }
        decimal Balance { get; set; }
        double InterestRate { get; set; }

    }
}