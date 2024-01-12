using System;

public class Solution {
    public int solution(int n) {
        if (n <= 0 || n > 1000)
        {
            throw new ArgumentOutOfRangeException("n이 제한사항을 벗어났습니다.");
        }
        int answer = 0;
        n = n%2==0?n:n-1;
        for(int i=n; i>0;){
            answer+=i;
            i-=2;
        }
        return answer;
    }
}