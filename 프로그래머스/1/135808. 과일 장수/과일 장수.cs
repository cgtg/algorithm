using System;
using System.Linq;
public class Solution {
    public int solution(int k, int m, int[] score) {
        int answer = 0;
        if(m > score.Length){
            return answer;
        }
        
        // 정렬해서 큰순서대로 m개씩
        Array.Sort(score, (a, b) => b.CompareTo(a));
        for(int i=0; i < score.Length; i+=m){
            int[] box = score.Skip(i).Take(m).ToArray();
            if(box.Length < m){
                break;
            }
            int minVal = box.Last();
            answer += minVal*m;
        }
        return answer;
    }
}