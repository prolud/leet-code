using Easy;

namespace LeetCode.Tests.Difficults.Easy
{
    public class RemoveDuplicatesFromSortedArrayTest
    {
        [Fact]
        public void RemoveDuplicatesFromSortedArray()
        {
            // Arrange
            RemoveDuplicatesExercice removeDuplicatesFromSortedArrayExercice = new RemoveDuplicatesExercice();

            int[] nums_1 = [1, 1, 2];
            int[] expect_1 = [1, 2];

            int[] nums_2 = [0, 0, 1, 1, 1, 2, 2, 3, 3, 4];
            int[] expect_2 = [0, 1, 2, 3, 4];

            int[] nums_3 = [0, 0, 0, 0, 3];
            int[] expect_3 = [0, 3];

            int[] nums_4 = [-1, 0, 0, 0, 0, 3, 3];
            int[] expect_4 = [-1, 0, 3];

            // Act
            var test_1 = removeDuplicatesFromSortedArrayExercice.RemoveDuplicates(nums_1);
            var test_2 = removeDuplicatesFromSortedArrayExercice.RemoveDuplicates(nums_2);
            var test_3 = removeDuplicatesFromSortedArrayExercice.RemoveDuplicates(nums_3);
            var test_4 = removeDuplicatesFromSortedArrayExercice.RemoveDuplicates(nums_4);

            // Assert
            Assert.Equal(expect_1.Length, test_1);
            for (int i = 0; i < test_1; i++)
            {
                Assert.Equal(expect_1[i], nums_1[i]);
            }

            Assert.Equal(expect_2.Length, test_2);
            for (int i = 0; i < test_2; i++)
            {
                Assert.Equal(expect_2[i], nums_2[i]);
            }

            Assert.Equal(expect_3.Length, test_3);
            for (int i = 0; i < test_3; i++)
            {
                Assert.Equal(expect_3[i], nums_3[i]);
            }
            
            Assert.Equal(expect_4.Length, test_4);
            for (int i = 0; i < test_4; i++)
            {
                Assert.Equal(expect_4[i], nums_4[i]);
            }
        }
    }
}