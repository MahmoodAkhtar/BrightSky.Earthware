using ReceiptPrinter.Domain;
using ReceiptPrinter.Interfaces;
using System;

namespace ReceiptPrinter.Services
{
    public class BasicsSalesTax : ISalesTaxStratergy
    {
        public double Appy(BasketItem item)
        {
            throw new NotImplementedException();
        }
    }
}