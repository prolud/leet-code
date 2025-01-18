// URL: https://leetcode.com/problems/two-sum/

public class TwoSumExercice
{
    public int[] TwoSum(int[] nums, int target)
    {
        for (int indexNumeroTeste = 0; indexNumeroTeste < nums.Length; indexNumeroTeste++)
        {
            int numeroTeste = nums[indexNumeroTeste];

            for (int indexNumeroSoma = 0; indexNumeroSoma < nums.Length; indexNumeroSoma++)
            {
                int numeroSoma = nums[indexNumeroSoma];

                if (numeroTeste + numeroSoma == target && indexNumeroTeste != indexNumeroSoma)
                {
                    return [indexNumeroTeste, indexNumeroSoma];
                }
            }
        }

        return [];
    }
}