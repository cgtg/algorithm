using System;

public class Solution {
    public int solution(int n) {
        if (n < 1 || n > 100000000)
        {
            throw new ArgumentOutOfRangeException("N은 100,000,000 이하의 자연수여야 합니다.");
        }
        
        int answer = 0;
        while(n > 0){
            answer += n%10;
            n/=10;
        }
        return answer;
    }
}