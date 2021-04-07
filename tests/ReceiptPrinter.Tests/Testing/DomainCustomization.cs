using AutoFixture;
using AutoFixture.AutoNSubstitute;

namespace ReceiptPrinter.Tests.Testing
{
    public class DomainCustomization : CompositeCustomization
    {
        public DomainCustomization()
            : base(new AutoNSubstituteCustomization())
        {
        }
    }
}