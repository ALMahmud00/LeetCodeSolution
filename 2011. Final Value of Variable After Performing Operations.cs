public class Solution {
    public int FinalValueAfterOperations(string[] operations) {
            
        var plusCount = operations.Where(x=> x == "X++" || x == "++X").Count();
        var minusCount = operations.Where(x=> x == "X--" || x == "--X").Count();
            
        return plusCount-minusCount;
    }
}