namespace Easy;

public class SearchInsertExercice
{
    public int SearchInsert(int[] nums, int target)
    {
        int correctIndex;
        for (correctIndex = 0; correctIndex < nums.Length && target >= nums[correctIndex]; correctIndex++)
        {
            if (nums[correctIndex] == target) return correctIndex;
        }

        return correctIndex;
    }
}
