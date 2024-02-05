using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int[] solution(int[] answers) {
        int[] supo1 = {1,2,3,4,5};
        int[] supo2 = {2,1,2,3,2,4,2,5};
        int[] supo3 = {3,3,1,1,2,2,4,4,5,5};
        
        int[] score = new int[3];
        for(int i=0; i<answers.Length; i++){
            if(answers[i] == supo1[i%supo1.Length]) score[0]++;
            if(answers[i] == supo2[i%supo2.Length]) score[1]++;
            if(answers[i] == supo3[i%supo3.Length]) score[2]++;
        }
        
        int maxScore = score.Max();
        List<int> answer = new List<int>();
        
        for (int i = 0; i < score.Length; i++) {
            if (score[i] == maxScore) answer.Add(i + 1);
        }
        
        return answer.ToArray();
    }
}