using System;
public class Solution {
    public int solution(int k, int m, int[] score) {
        int answer = 0;
        // 정렬해서 뒤에서부터 탐색. 상자 마지막에 위치할 값만 가져와 계산
        Array.Sort(score);
        for(int i=score.Length-m; i >= 0 ; i-=m){
            answer += score[i] * m;
        }
        return answer;
    }
}