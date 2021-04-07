namespace ReceiptPrinter.Interfaces
{
    using Domain;

    public interface IReceiptPrinter
    {
        string Print(Receipt receipt);
    }
}