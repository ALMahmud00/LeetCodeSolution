public class Solution {
    public int[] RunningSum(int[] nums) {
        var n = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                nums[i] = nums[i] + n;
                n = nums[i];
            }

            return nums;
    }
}
