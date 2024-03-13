using Claculator;

namespace TestProject1
{
    public class CalculatorTest
    {
        [Fact]
        public void AddTest()
        {
            // Arrange  
            double a = 5;
            double b = 3;
            double expected = 8;

            // Act 
            double actual = MathUnit.Add(a, b);

            // Assert
            Assert.Equal(expected, actual);

        }
    }
}