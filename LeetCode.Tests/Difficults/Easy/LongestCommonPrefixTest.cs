namespace LeetCode.Tests.Difficults.Easy
{
    public class LongestCommonPrefixTest
    {
        [Fact]
        public void LongestCommonPrefix()
        {
            // Arrange
            LongestCommonPrefixExercice longestCommonPrefixExercice = new LongestCommonPrefixExercice();

            // Act
            var result_1 = longestCommonPrefixExercice.LongestCommonPrefix(["dog", "racecar", "car"]);
            var result_2 = longestCommonPrefixExercice.LongestCommonPrefix(["flower", "flow", "flight"]);
            var result_3 = longestCommonPrefixExercice.LongestCommonPrefix([""]);
            var result_4 = longestCommonPrefixExercice.LongestCommonPrefix(["a"]);
            var result_5 = longestCommonPrefixExercice.LongestCommonPrefix(["ab", "a"]);
            var result_6 = longestCommonPrefixExercice.LongestCommonPrefix(["cir", "car"]);
            var result_7 = longestCommonPrefixExercice.LongestCommonPrefix(["reflower", "flow", "flight"]);

            // Assert
            Assert.Equal("", result_1);
            Assert.Equal("fl", result_2);
            Assert.Equal("", result_3);
            Assert.Equal("a", result_4);
            Assert.Equal("a", result_5);
            Assert.Equal("c", result_6);
            Assert.Equal("", result_7);
        }
    }
}