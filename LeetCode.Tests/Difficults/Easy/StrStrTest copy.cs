using Easy;

namespace LeetCode.Tests.Difficults.Easy
{
    public class SearchInsertTest
    {
        [Fact]
        public void SearchInsert()
        {
            // Arrange
            SearchInsertExercice validParenthesesExercice = new SearchInsertExercice();

            // Act
            var test_1 = validParenthesesExercice.SearchInsert([1,3,5,6], 5);
            var test_2 = validParenthesesExercice.SearchInsert([1,3,5,6], 2);

            // Assert
            Assert.Equal(2, test_1);
            Assert.Equal(1, test_2);
        }
    }
}