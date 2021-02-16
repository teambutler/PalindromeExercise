using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        
            [Theory]
            [InlineData("racecar", true)]
            [InlineData("hello", false)]
            public void MyTest(string word, bool expected)
            {
            //arr

            var tester = new WordSmith();

            //act

            var actual = tester.IsAPalindrome(word);

            //assert

            Assert.Equal(expected, actual);



            }
        
    }
}
