using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {

        //[InlineData()] // ← you will need to put some test data and expected result here.  
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("car", false)]
        public void Test1(string word,bool expected)
        {

            var tester = new WordSmith();

            var total=tester.IsAPalindrome(word);

            Assert.Equal(expected, total);




        }
    }
}
