using ReceiptPrinter.Domain;
using ReceiptPrinter.Interfaces;
using System;

namespace ReceiptPrinter.Services
{
    public class ImportedSalesTax : ISalesTaxStratergy
    {
        private readonly IGoodsClassifier _classifier;

        public ImportedSalesTax(IGoodsClassifier classifier)
        {
            _classifier = classifier;
        }

        public double Appy(BasketItem item)
        {
            throw new NotImplementedException();
        }
    }
}