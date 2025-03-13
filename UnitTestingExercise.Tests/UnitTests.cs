using System;
using Xunit;

namespace UnitTestingExercise.Tests

{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]
        [InlineData(5, 5, 5, 15)]
        [InlineData(-10, -5, 2, -13)]
        [InlineData(1, 0, 0, 1)]//Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            var test = new Calculator();
            
            //Act
            int actual  = test.Add(num1, num2, num3);
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual

            //Assert
                //Assert.Equal(expected, actual);
                Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 1, 1)]//Add test data <-------
        [InlineData(15, 3, 12)]
        [InlineData(6, 2, 4)]
        [InlineData(-10, 2, -8)]
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var test = new Calculator();

            //Act
            int actual = test.Subtract(minuend, subtrhend);
            
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(-1, 5, -5)]
        [InlineData(0, 2, 0)]
        [InlineData(8, 8, 64)]
        [InlineData( 3, 5, 15)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange 
            var test = new Calculator();

            //Act
            int actual = test.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 2, 5)]
        [InlineData(20, 4, 5)]
        [InlineData(-10, 2, -5)]
        [InlineData(60, 0, 0)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var test = new Calculator();

            //Act
            int actual = test.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

    }
}
