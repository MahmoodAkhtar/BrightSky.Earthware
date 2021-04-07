namespace ReceiptPrinter.Interfaces
{
    using ReceiptPrinter.Domain;

    public interface IGoodsClassifier
    {
        GoodsType Classify(BasketItem item);
    }
}