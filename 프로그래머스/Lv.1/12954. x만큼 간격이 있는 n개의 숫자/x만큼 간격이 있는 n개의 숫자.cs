using System;
public class Solution {
    public long[] solution(long x, int n) {
        if(x < -10000000 || x > 10000000){
            throw new ArgumentOutOfRangeException("X가 범위를 벗어났습니다.");
        }
        if(n <= 0 || n > 1000){
            throw new ArgumentOutOfRangeException("N이 범위를 벗어났습니다.");
        }
        
        long[] answer = new long[n];
        for(int i = 0; i<n; i++){
            answer[i] = x * (i+1);
        }
        return answer;
    }
}