using System;
public class Solution {
    public long solution(int a, int b) {
        if(a==b) return a;
        int s = Math.Min(a,b);
        int e = Math.Max(a,b);
        long answer = 0;
        for(int i=s;i<=e;i++){
            answer+=i;
        }
        return answer;
    }
}