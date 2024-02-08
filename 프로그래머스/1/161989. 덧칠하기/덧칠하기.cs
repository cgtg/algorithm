using System;

public class Solution {
    public int solution(int n, int m, int[] section) {
        int answer = 0;
        int curPos = 0;
        foreach(int s in section){
            if(s > curPos){
                curPos = s+m-1;
                answer++;
            }
        }
        return answer;
    }
}