using System.Collections.Generic;

namespace ReceiptPrinter.Interfaces
{
    using Domain;

    public interface IReceiptGenerator
    {
        Receipt Generate(IEnumerable<BasketItem> items);
    }
}