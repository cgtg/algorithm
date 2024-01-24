using System;

public class Solution {
    public int solution(string t, string p) {
        int answer = 0;
        int tLength = t.Length;
        int pLength = p.Length;
        long pNum = Convert.ToInt64(p);
        for (int i = 0; i <= tLength - pLength; i++)
        {
            string substring = t.Substring(i, pLength);
            long tNum = Convert.ToInt64(substring);
            if (tNum <= pNum)
            {
                answer++;
            }
        }
        return answer;
    }
}