using AutoFixture;
using AutoFixture.Xunit2;

namespace ReceiptPrinter.Tests.Testing
{
    public class AutoDomainDataAttribute : AutoDataAttribute
    {
        public AutoDomainDataAttribute()
            : base(() =>
            {
                var fixture = new Fixture().Customize(new DomainCustomization());

                return fixture;
            })
        {
        }
    }
}