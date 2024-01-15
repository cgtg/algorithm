using System;
public class Solution {
    public int[] solution(long n) {
        if(n <= 0 || n > 10000000000){
            throw new ArgumentOutOfRangeException("N이 범위를 벗어났습니다.");
        }
        string numStr = n.ToString();
        int[] answer = new int[numStr.Length];
        
        for(int i = numStr.Length -1; i >=0; i--){
            answer[numStr.Length -1 -i] = int.Parse(numStr[i].ToString());
        }
        
        return answer;
    }
}