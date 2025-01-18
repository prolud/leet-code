namespace LeetCode.Tests.Difficults.Easy
{
    public class TwoSumTest
    {
        [Fact]
        public void TwoSum()
        {
            // Arrange
            TwoSumExercice twoSumExercice = new TwoSumExercice();

            // Act
            int[] array_test_1 = [2, 7, 11, 15];
            int target_test_1 = 9;
            var test_1 = twoSumExercice.TwoSum(array_test_1, target_test_1);

            int[] array_test_2 = [3, 2, 4];
            int target_test_2 = 6;
            var test_2 = twoSumExercice.TwoSum(array_test_2, target_test_2);

            int[] array_test_3 = [3, 3];
            int target_test_3 = 6;
            var test_3 = twoSumExercice.TwoSum(array_test_3, target_test_3);

            // Assert
            Assert.True(array_test_1[test_1[0]] + array_test_1[test_1[1]] == target_test_1);
            Assert.True(array_test_2[test_2[0]] + array_test_2[test_2[1]] == target_test_2);
            Assert.True(array_test_3[test_3[0]] + array_test_3[test_3[1]] == target_test_3);
        }
    }
}