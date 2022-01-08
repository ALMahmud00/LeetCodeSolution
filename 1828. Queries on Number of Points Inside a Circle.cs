public class Solution {
   public int[] CountPoints(int[][] points, int[][] queries)
        {
            int[] res = new int[queries.Length];
            for(int qr = 0; qr < queries.Length; qr++)
            {
                int totalPoint = 0;
                for (int pnt = 0; pnt < points.Length; pnt++)
                {
                    if(IsBetween(points[pnt][0], points[pnt][1], queries[qr][0], queries[qr][1], queries[qr][2]) == true)
                    {
                        totalPoint++;
                    }
                }
                res[qr] = totalPoint;
            }
            return res;
        }
        public static bool IsBetween(int x, int y, int a, int b, int r)
        {
            if (Math.Sqrt(Math.Pow((x - a), 2) + Math.Pow((y - b), 2)) <= r)
            {
                return true;
            }
            else return false;
        }
}