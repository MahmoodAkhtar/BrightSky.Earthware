using AutoFixture.Xunit2;

namespace ReceiptPrinter.Tests.Testing
{
    public class InlineAutoDomainDataAttribute : InlineAutoDataAttribute
    {
        public InlineAutoDomainDataAttribute(params object[] objects)
            : base(new AutoDomainDataAttribute(), objects)
        {
        }
    }
}