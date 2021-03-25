using System;
using Xunit;

namespace Lab03.Tests
{
    public class Challenge1Tests1
    {
        [Fact]
        public void UserArray_returns_an_array_of_3_integers()
        {

            //Arrange
            int[] userArray = new int[3];

            //Act
            int[] result = [userArray];

            //Assert
            Assert.Equal(3, result.Length);

        }
    }
}
