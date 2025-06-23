namespace Easy;

public class RemoveElementExercice
{
    public int RemoveElement(int[] nums, int val)
    {
        var filtered = nums.Where(_ => _ != val).ToArray();
        
        for (int i = 0; i < filtered.Count(); i++)
        {
            nums[i] = filtered[i];
        }

        return filtered.Count();
    }
}
