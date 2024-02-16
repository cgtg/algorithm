using System;

public class Solution {
    public int solution(int number, int limit, int power) {
        int answer = 0;
        
        for(int i = 1; i<= number; i++){
            answer += GetAtkPow(i, limit, power);
        }
        return answer;
    }
    
    public int GetAtkPow(int i, int limit, int power) {
        int cnt =0;
        int sqrtNum = (int)Math.Sqrt(i);

        for (int j = 1; j <= sqrtNum; j++) {
            if (i % j == 0) {
                cnt += 2;
            }
        }
        if (sqrtNum * sqrtNum == i)
        {
            cnt--;
        }
        
        return cnt>limit? power:cnt;
    }
}