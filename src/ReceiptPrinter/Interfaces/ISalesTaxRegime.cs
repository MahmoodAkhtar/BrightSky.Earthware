using ReceiptPrinter.Domain;

namespace ReceiptPrinter.Interfaces
{
    public interface ISalesTaxRegime
    {
        void Register(ISalesTaxStratergy stratergy);

        double Appy(BasketItem[] items);
    }
}