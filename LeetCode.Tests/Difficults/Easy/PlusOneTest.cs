using Easy;

namespace LeetCode.Tests.Difficults.Easy
{
    public class PlusOneTest
    {
        [Fact]
        public void PlusOne_Test1()
        {
            // Arrange
            PlusOneExercice plusOneExercice = new PlusOneExercice();
            int[] digits = [9];
            int[] expected = [1, 0];

            // Act
            var result = plusOneExercice.PlusOne(digits);

            // Assert
            Assert.Equal(expected.Length, result.Length);
            for (int i = 0; i < result.Length; i++)
            {
                Assert.Equal(expected[i], result[i]);
            }
        }
    }
}