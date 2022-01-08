public class Solution {
    public int[] TwoSum(int[] nums, int target) {
         int i, j;
            int[] result = new int[2];
            for (i = 0; i < nums.Length; i++)
            {
                for (j = 0; j < nums.Length; j++)
                {
                    if (i != j && nums[i] + nums[j] == target)
                    {
                        result[0] = i;
                        result[1] = j;
                        break;
                    }
                }
                if (j != nums.Length) break;
            }

            return result;
    }
}