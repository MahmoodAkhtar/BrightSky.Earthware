using ReceiptPrinter.Domain;
using ReceiptPrinter.Interfaces;
using System;

namespace ReceiptPrinter.Services
{
    public class PlainTextReceiptPrinter : IReceiptPrinter
    {
        public string Print(Receipt receipt)
        {
            throw new NotImplementedException();
        }
    }
}