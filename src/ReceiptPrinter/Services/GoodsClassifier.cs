using ReceiptPrinter.Domain;
using ReceiptPrinter.Interfaces;
using System;

namespace ReceiptPrinter.Services
{
    public class GoodsClassifier : IGoodsClassifier
    {
        public GoodsType Classify(BasketItem item)
        {
            throw new NotImplementedException();
        }
    }
}