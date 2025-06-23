using Easy;

namespace LeetCode.Tests.Difficults.Easy
{
    public class ValidParenthesesTest
    {
        [Fact]
        public void ValidParentheses()
        {
            // Arrange
            ValidParenthesesExercice validParenthesesExercice = new ValidParenthesesExercice();

            // Act
            var test_1 = validParenthesesExercice.IsValid("(){}[]");

            var test_2 = validParenthesesExercice.IsValid("({})");

            var test_3 = validParenthesesExercice.IsValid("([)]");

            var test_4 = validParenthesesExercice.IsValid("()]");

            var test_5 = validParenthesesExercice.IsValid("[([]])");

            // Assert
            Assert.True(test_1);
            Assert.True(test_2);
            Assert.False(test_3);
            Assert.False(test_4);
            Assert.False(test_5);
        }
    }
}