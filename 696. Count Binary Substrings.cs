public class Solution {
    public int CountBinarySubstrings(string s) {
    int res = 0, prev = 0, curr;
    for (int i = 0; i < s.Length; i += curr) {
        curr = 1;
        while (i + curr < s.Length && s[i] == s[i + curr]) {
            curr++;
        }
        res += Math.Min(prev, curr);
        prev = curr;
    }
    return res;
}
}