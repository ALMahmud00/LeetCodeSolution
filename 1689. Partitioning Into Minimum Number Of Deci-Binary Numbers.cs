public class Solution {
    public int MinPartitions(string n) {
         return n.Select(x => (int)char.GetNumericValue(x)).Max();
    }
}