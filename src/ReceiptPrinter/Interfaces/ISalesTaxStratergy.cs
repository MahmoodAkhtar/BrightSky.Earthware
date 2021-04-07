using ReceiptPrinter.Domain;

namespace ReceiptPrinter.Interfaces
{
    public interface ISalesTaxStratergy
    {
        double Appy(BasketItem item);
    }
}