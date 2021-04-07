namespace ReceiptPrinter.Domain
{
    public record BasketItem(
        string Name,
        bool IsImported,
        double Price,
        int Quantity);
}