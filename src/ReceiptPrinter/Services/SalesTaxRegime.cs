using ReceiptPrinter.Domain;
using ReceiptPrinter.Interfaces;
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
            double tax = 0;

            foreach (var item in items)
                foreach (var stratergy in _stratergies)
                    tax += stratergy.Appy(item);

            return tax;
        }

        public void Register(ISalesTaxStratergy stratergy)
            => _stratergies.Add(stratergy);
    }
}