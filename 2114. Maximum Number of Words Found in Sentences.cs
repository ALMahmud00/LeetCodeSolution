public class Solution {
    public int MostWordsFound(string[] sentences)
        {
            int sum = 0, count = 0, max = 0, i , j;
            for (i = 0; i< sentences.Length; i++)
            {   count = 0;
                for (j = 0; j < sentences[i].Length; j++)
                {
                    if(sentences[i][j] == ' ')
                        count++;
                }
                if(count>max)
                    max = count;
            }
            return max + 1;
        }
}