public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        int[] result = new int[2];
        int size = nums.Length;
        for (int i = 0; i < size; i++)
        {
            int curr = nums[i];
            int target_variable = target - curr;
            for (int j = 0; j < size; j++)
            {
                if (target_variable == nums[j] && i != j)
                {
                    result[0] = i;
                    result[1] = j;
                    break;
                }
            }
        }
        return result;
    }
}