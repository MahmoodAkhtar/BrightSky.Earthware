using ReceiptPrinter.Domain;
using ReceiptPrinter.Interfaces;
using System;
using System.Collections.Generic;

namespace ReceiptPrinter.Services
{
    public class ReceiptGenerator : IReceiptGenerator
    {
        public Receipt Generate(IEnumerable<BasketItem> items)
        {
            throw new NotImplementedException();
        }
    }
}