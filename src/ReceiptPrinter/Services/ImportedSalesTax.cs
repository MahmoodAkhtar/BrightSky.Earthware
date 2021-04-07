using ReceiptPrinter.Domain;
using ReceiptPrinter.Interfaces;

namespace ReceiptPrinter.Services
{
    public class ImportedSalesTax : ISalesTaxStratergy
    {
        public double Appy(BasketItem item)
        {
            double tax = 0;

            if (item.IsImported)
                tax = item.Price * 0.05;

            return tax;
        }
    }
}