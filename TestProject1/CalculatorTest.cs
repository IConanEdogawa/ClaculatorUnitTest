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

        [Fact]
        public void SubtractTest()
        {
            // Arrange
            double a = 5;
            double b = 3;
            double expected = 2;

            // Act
            double actual = MathUnit.Sub(a, b);

            // Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void MultiplyTest()
        {
            // Arrange
            double a = 2;
            double b = 3;
            double expected = 6;

            // Act
            double actual = MathUnit.Mul(a, b);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DivideTest() 
        {
            // Arrange 
            List<double> a = new List<double>() { 1, 2, 3, 4, 5 };
            List<double> b = new List<double>() { 1, 3, 2, 4, 10 }; 
            List<double> expected = new List<double>() { 1, 0.5, 1.5, 1, 0.5 };

            // Act & Assert 
            for (int i = 0; i < a.Count; i++)
            {
                try
                {
                    double actual = MathUnit.Div(a[i], b[i]);
                    Assert.Equal(expected[i], actual); 
                }
                catch (DivideByZeroException ex)
                {
                    // Divide by zero at index 0
                    Console.WriteLine($"Divide by zero at index {i}");
                }
            }
            
        }


        [Fact]
        public void PowerTest()
        {
            // Arrange
            double a = 2;
            int b = 3;
            int expected = 8;

            // Act 
            double actual = MathUnit.Pow(a, b);

            // Assert
            Assert.Equal(expected, actual);

            
        }

        [Fact]
        public void SqrtTest()
        {
            // Arrange
            double a = 81;
            double expected = 9;

            // Act
            double actual = MathUnit.Sqrt(a);

            // Assert
            Assert.Equal(expected, actual);

            // Arrange (Sqrt test with negative number)
            double b = -9;
            double expected2 = 0;

            // Act
            double actual2 = MathUnit.Sqrt(b);

            // Assert
            Assert.Equal(expected2, actual2);

            // Arrange (Sqrt test with zero)
            double c = 0;
            double expected3 = 0;

            // Act
            double actual3 = MathUnit.Sqrt(c);

            // Assert
            Assert.Equal(expected3, actual3);

            
        }




    }
}