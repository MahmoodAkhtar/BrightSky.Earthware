using ReceiptPrinter.Domain;
using ReceiptPrinter.Interfaces;
using System;

namespace ReceiptPrinter.Services
{
    public class BasicsSalesTax : ISalesTaxStratergy
    {
        private readonly IGoodsClassifier _classifier;

        public BasicsSalesTax(IGoodsClassifier classifier)
        {
            _classifier = classifier;
        }

        public double Appy(BasketItem item)
        {
            double tax = 0;

            if (_classifier.Classify(item) == GoodsType.Unknown)
                tax = item.Price * 0.1;

            return tax;
        }
    }
}