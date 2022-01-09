public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
            var data = new List<int>();
            data.AddRange(nums1);
            data.AddRange(nums2);
            var res = data.OrderBy(x=>x).ToArray();

            if(res.Count() % 2 == 0)
            {
                return (double)((double)(res[res.Count()/2 - 1] + res[res.Count()/2]) / 2);
            }
            else
            {
                return res[(res.Count() - 1) / 2];
            }
    }
}
