using System;
public class Solution {
    public int solution(int n) {
        if(n<0 || n>3000){
            throw new ArgumentOutOfRangeException("N이 범위를 벗어났습니다.");
        }
        int answer = 0;
        for(int i=1; i<=n; i++){
            if(n%i==0){
                answer+=i;
            }
        }
        return answer;
    }
}