using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("cow", false)]
        [InlineData("racecar", true)]// ← you will need to put some test data and expected result here.  
        [InlineData("hannah", true)]
        [InlineData("taco", false)]
        [InlineData("tacocat", true)]

        // For example [InlineData(“racecar”, true)]
        public void Test1(string data,bool expected)
        {
            //Arrange
            var test = new WordSmith();

            //Act
            var actual = test.IsAPalindrome(data);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
