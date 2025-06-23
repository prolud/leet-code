using Easy;

namespace LeetCode.Tests.Difficults.Easy
{
    public class MergeTwoSortedListsTest
    {
        [Fact]
        public void MergeTwoLists()
        {
            // Arrange
            MergeTwoListsExercice validParenthesesExercice = new MergeTwoListsExercice();

            var list1 = new ListNode(1, new ListNode(2, new ListNode(4)));
            var list2 = new ListNode(1, new ListNode(3, new ListNode(4)));
            var merged = new ListNode(1, new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(4))))));

            // Act
            var test_1 = validParenthesesExercice.MergeTwoLists(list1, list2);

            // Assert
            Assert.True(AreEqual(merged, test_1));
        }

        private static bool AreEqual(ListNode a, ListNode b)
        {
            while (a != null && b != null)
            {
                if (a.val != b.val) return false;
                a = a.next;
                b = b.next;
            }
            return a == null && b == null;
        }

    }
}