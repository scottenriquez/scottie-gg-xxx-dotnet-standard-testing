using FluentAssertions;
using Gg.Scottie.Dotnet.Standard.Testing.Demo.Domain;
using NUnit.Framework;

namespace Gg.Scottie.Dotnet.Standard.Testing.Unit.Tests
{
    [TestFixture]
    public class AdditionServiceTests
    {
        [Test]
        public void Should_Add_ForStandardInput()
        {
            //arrange
            decimal first = 1.0m;
            decimal second = 2.0m;
            decimal expectedSum = 3.0m;
            IAdditionService additionService = new AdditionService();
            
            //act
            decimal actualSum = additionService.Add(first, second);

            //assert
            actualSum.Should().Be(expectedSum);
        }
    }
}