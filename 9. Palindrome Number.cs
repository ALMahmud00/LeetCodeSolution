public class Solution 
{
    public bool IsPalindrome(int x) 
    {
       if (x < 0)
        {
            return false;
        }
        List<int> intList = new List<int>();
        while (x > 0)
        {
            intList.Add(x % 10);
            x = x / 10;
        }
        for (int i = 0, j = intList.Count() - 1; i < intList.Count() / 2; i++, j--)
        {
            if (intList[i] != intList[j])
            {
                return false;
            }
        }
        return true;     
    }
}
