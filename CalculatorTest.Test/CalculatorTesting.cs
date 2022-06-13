using Labb_3_XUnit_Acceptanstestning;
using System;
using Xunit;

namespace CalculatorTest.Test
{
    public class CalculatorTesting
    {
        [Fact]
        public void Division_Test_50_Divided_By_2_Return_25()
        {
            // Arrange + Act
            var sut = Division.UseDivision(50, 2);
            // Assert
            Assert.Equal(25, sut);
        }

        [Fact]
        public void Multiplikation_Test_50_multiplied_by_3_Return_150()
        {
            // Arrange + Act
            var sut = Multiplikation.UseMultiplikation(50, 3);
            // Assert
            Assert.Equal(150, sut);
        }

        [Fact]
        public void Subtraktion_Test_100_Minus_25_Return_75()
        {
            // Arrange + Act
            var sut = Subtraktion.UseSubtraktion(100,25);
            // Assert
            Assert.Equal(75,sut);

        }

        [Fact]
        public void Addition_Test_50_Plus_50_Return_100()
        {
            // Arrange + Act
            var sut = Addition.UseAddition(50,50);
            // Assert
            Assert.Equal(100,sut);
        }

        [Theory]
        [InlineData(20, 2, 22, true)]
        [InlineData(50, 34, 84, true)]
        [InlineData(40, 20, 10, false)]
        [InlineData(0.5, 0.14, 0.64, true)]
        [InlineData(500.5, 1.5, 502, true)]

        public void Theory_Test_Using_Addition(double x,double y,double sum,bool expected)
        {
            var actual = Addition.UseAddition(x,y);
            bool actualBool;
            if (actual == sum)
            {
                actualBool = true;
            }
            else
            {
                actualBool = false;
            }
            Assert.Equal(expected, actualBool);
        }


    }
}
