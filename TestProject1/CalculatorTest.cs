using System.Diagnostics.CodeAnalysis;
using Xunit.Sdk;

namespace TestProject1
{
    public class CalculatorTest
    {
        [Fact]
        public void Test1()
        {
            double num1 = 65;
            double num2 = 65;
            double expected = 130;
            double actual = Calculator.Addition.ToAdd(num1,num2);
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(42, 36, 78)]
        [InlineData(10, 21, 31 )]
        [InlineData(74, 108, 182)]
        public void AdditionToAddTest(double num1,double num2, double expected)
        {
            double actual = Calculator.Addition.ToAdd(num1, num2);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Test2()
        {
            double num1 = 6;
            double num2 = 0;
           Assert.Throws<DivideByZeroException>(()=>Calculator.Division.ToDivide(num1,num2));
        }
    }
}
