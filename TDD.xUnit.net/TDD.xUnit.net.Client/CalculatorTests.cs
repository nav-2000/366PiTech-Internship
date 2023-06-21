using CalculatorLib;
using Moq;
using System.Diagnostics.CodeAnalysis;
using Xunit;

namespace TDD.xUnit.net.Client
{
    [ExcludeFromCodeCoverage]
    public class CalculatorTests
    {

        [Fact]
        public void AddTest()
        {
            var calculator = new FakeCalculator();
            Assert.Equal(5, calculator.Add(2, 3));
        }

        [Fact]
        public void PassingTest()
        {
            //var calculator = new ICalculator();  
            //Assert.Equal(4, calculator.Add(2, 2));  

            var calculator = new Mock<ICalculator>();
            calculator.Setup(x => x.Add(2, 2)).Returns(4);
            Assert.Equal(4, calculator.Object.Add(2, 2));
        }
    }
}