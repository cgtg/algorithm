using System;

public class Solution {
    public string solution(string s, string skip, int index) {
        string answer = "";
        foreach (char c in s) {
            int ascii = c; // char->int 자동 형 변환
            for (int i = 0; i < index; i++) {
                ascii++;
                if (ascii > 'z') ascii = 'a';
                while (skip.Contains((char)ascii)) {
                    ascii++;
                    if (ascii > 'z') ascii = 'a';
                }
            }
            answer += (char)ascii;
        }
        return answer;
    }
}