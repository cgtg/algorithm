using System;

public class Solution {
    public int solution(int n) {
        if(n < 3 || n > 1000000){
            throw new ArgumentOutOfRangeException("N이 범위를 벗어났습니다.");
        }
        int i=2;
        for(; i <= n-1; i++ )
        {
            if((n-1)%i == 0){
                break;
            }
        }
        return i;
    }
}
