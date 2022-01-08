public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            int MaxNumber = candies.Max();
            IList<bool> res = new List<bool>();
            candies.ToList().ForEach(num =>
            {
                if(num >= MaxNumber || (num + extraCandies) >= MaxNumber)
                {
                    res.Add(true);
                }
                else
                {
                    res.Add(false);
                }
            });
            return res;
        }
}