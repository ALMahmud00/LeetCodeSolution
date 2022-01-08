using System.Collections.Generic;
public class Solution {
    public int[] GetConcatenation(int[] nums) {
        List<int> result = new List<int>();

            result.AddRange(nums);
            result.AddRange(nums);
            
            return result.ToArray();
    }
}