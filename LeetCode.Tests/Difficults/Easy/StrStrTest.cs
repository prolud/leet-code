using Easy;

namespace LeetCode.Tests.Difficults.Easy
{
    public class StrStrTest
    {
        [Fact]
        public void StrStr()
        {
            // Arrange
            StrStrExercice validParenthesesExercice = new StrStrExercice();

            // Act
            var test_1 = validParenthesesExercice.StrStr("sadbutsad", "sad");
            var test_2 = validParenthesesExercice.StrStr("leetcode", "leeto");
            var test_3 = validParenthesesExercice.StrStr("a", "a");

            // Assert
            Assert.Equal(0, test_1);
            Assert.Equal(-1, test_2);
            Assert.Equal(0, test_3);
        }
    }
}