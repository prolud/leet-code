namespace Easy;

public class RemoveDuplicatesExercice
{
    public int RemoveDuplicates(int[] nums)
    {
        var sortedGrouped = nums.Distinct().Order().ToArray();
        
        for (int i = 0; i < sortedGrouped.Count(); i++)
        {
            nums[i] = sortedGrouped[i];
        }

        return sortedGrouped.Count();
    }
}
