using System.Collections.Generic;

namespace ReceiptPrinter.Domain
{
    public record Receipt(
        IEnumerable<BasketItem> Items,
        double SalesTax,
        double Total);
}