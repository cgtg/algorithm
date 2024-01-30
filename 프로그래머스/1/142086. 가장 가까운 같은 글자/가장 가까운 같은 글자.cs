using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(string s) {
        int[] answer = new int[s.Length];
        Dictionary<char, int> position = new Dictionary<char, int>();
        for (int i = 0; i < s.Length; i++)
        {
            char currentChar = s[i];
            if (position.ContainsKey(currentChar))
            {
                answer[i] = i - position[currentChar];
            }
            else
            {
                answer[i] = -1;
            }
            position[currentChar] = i;
        }
        return answer;
    }
}