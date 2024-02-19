using System;
using System.Linq;
public class Solution {
    public int[] solution(int[] lottos, int[] win_nums) {
        int[] answer = new int[2];
        int unknownCount = lottos.Count(x => x == 0);
        int correctCount = lottos.Intersect(win_nums).Count();
        
        answer[0] = GetRank(correctCount + unknownCount);
        answer[1] = GetRank(correctCount);
        
        return answer;
    }
    
    private int GetRank(int count) {
        switch(count){
            case 6: return 1;
            case 5: return 2;
            case 4: return 3;
            case 3: return 4;
            case 2: return 5;
            default: return 6;
        }
    }
}