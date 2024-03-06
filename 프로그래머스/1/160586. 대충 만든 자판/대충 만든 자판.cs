using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(string[] keymap, string[] targets) {
        Dictionary<char, int> keyDict = new Dictionary<char, int>();
        for (int i = 0; i < keymap.Length; i++)
        {
            for (int j = 0; j < keymap[i].Length; j++)
            {
                if (!keyDict.ContainsKey(keymap[i][j]))
                {
                    keyDict[keymap[i][j]] = j + 1;
                }
                else
                {
                    keyDict[keymap[i][j]] = Math.Min(keyDict[keymap[i][j]], j + 1);
                }
            }
        }
        
        int[] answer = new int[targets.Length];
        for(int i = 0; i < targets.Length; i++) {
            int count = 0;
            for(int j = 0; j < targets[i].Length; j++) {
                if(!keyDict.ContainsKey(targets[i][j])) {
                    count = -1;
                    break;
                }
                count += keyDict[targets[i][j]];
            }
            answer[i] = count;
        }
        
        
        return answer;
    }
}