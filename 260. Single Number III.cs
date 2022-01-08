public class Solution {
    public int[] SingleNumber(int[] nums) {
        int[] res = new int[2];
        int i, j, k = 0;
        for (i = 0; i < nums.Length; i++)
        {
            for(j = 0; j<nums.Length; j++)
            {
                if(nums[i] == nums[j] && i != j)
                {
                    break;
                }
            }
            if (j == nums.Length)
            {
                res[k++] = nums[i];
            }
            if(k == 2)
            {
                break;
            }
        }

        return res;
    }
}