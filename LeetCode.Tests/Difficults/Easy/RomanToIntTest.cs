namespace LeetCode.Tests.Difficults.Easy
{
    public class RomanToIntTest
    {
        [Fact]
        public void RomanToInt()
        {
            // Arrange
            RomanToIntegerExercice romanToIntergerExercice = new RomanToIntegerExercice();

            // Act
            var result_1 = romanToIntergerExercice.RomanToInt("IV");
            var result_2 = romanToIntergerExercice.RomanToInt("III");
            var result_3 = romanToIntergerExercice.RomanToInt("LVIII");
            var result_4 = romanToIntergerExercice.RomanToInt("MCMXCIV");

            // Assert
            Assert.Equal(4, result_1);
            Assert.Equal(3, result_2);
            Assert.Equal(58, result_3);
            Assert.Equal(1994, result_4);
        }
    }
}