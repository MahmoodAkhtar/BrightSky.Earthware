using ReceiptPrinter.Domain;
using ReceiptPrinter.Interfaces;
using System;
using System.Collections.Generic;

namespace ReceiptPrinter.Services
{
    public class SalesTaxRegime : ISalesTaxRegime
    {
        private readonly List<ISalesTaxStratergy> _stratergies;

        public SalesTaxRegime()
        {
            _stratergies = new List<ISalesTaxStratergy>();
        }

        public double Appy(BasketItem[] items)
        {
            throw new NotImplementedException();
        }

        public void Register(ISalesTaxStratergy stratergy)
        {
            throw new NotImplementedException();
        }
    }
}