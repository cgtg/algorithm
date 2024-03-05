using System;

public class Solution {
    public int solution(string s) {
        int answer = 0;
        while(s.Length > 0){
            char x = s[0];
            int countX = 0;
            int countNotX = 0;
            
            for(int i = 0; i < s.Length; i++) {
                if(s[i] == x) countX++;
                else countNotX++;
                
                if(countX == countNotX) {
                    answer++;
                    s = s.Substring(i + 1);
                    break;
                }
                if(i == s.Length - 1) {
                    // 마지막조각
                    answer++;
                    s = "";
                }
            }
        }
        
        return answer;
    }
}