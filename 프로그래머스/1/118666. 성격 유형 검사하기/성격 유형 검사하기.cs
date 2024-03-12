using System;
using System.Collections.Generic;
public class Solution {
    public string solution(string[] survey, int[] choices) {
        Dictionary<char, int> typeScores = new Dictionary<char, int> {
            {'R', 0}, {'T', 0}, {'C', 0}, {'F', 0},
            {'J', 0}, {'M', 0}, {'A', 0}, {'N', 0}
        };
        
        for (int i = 0; i < survey.Length; i++) {
            char disagreeType = survey[i][0];
            char agreeType = survey[i][1];
            int choice = choices[i];
            int score = 0;

            if (choice < 4) { // 비동의
                score = 4 - choice;
                typeScores[disagreeType] += score;
            } else if (choice > 4) { // 동의
                score = choice - 4;
                typeScores[agreeType] += score;
            }
        }

        // 최종 성격 유형 문자열 생성
        string answer = "";
        answer += typeScores['R'] >= typeScores['T'] ? 'R' : 'T';
        answer += typeScores['C'] >= typeScores['F'] ? 'C' : 'F';
        answer += typeScores['J'] >= typeScores['M'] ? 'J' : 'M';
        answer += typeScores['A'] >= typeScores['N'] ? 'A' : 'N';
        return answer;
    }
}