public class Solution {
    public int SingleNumber(int[] nums) {
         var dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]))
                {
                    dict[nums[i]] += 1;
                }
                else
                {
                    dict.Add(nums[i],1);
                }
            }
            return dict.OrderBy(x=>x.Value).FirstOrDefault().Key;
    }
}

