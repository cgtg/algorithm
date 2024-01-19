using System;

public class Solution {
    public int solution(int left, int right) {
        int answer = 0;
        for(int i=left;i<=right;i++){
            int cnt = 0;
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
            
            if (cnt % 2 == 0) {
                answer += i;
            } else {
                answer -= i;
            }
        }
        return answer;
    }
}