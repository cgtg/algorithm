public class Solution {
    public int solution(int num) {
        int answer = 0;
        long curTmp = num;
        while(answer<500)
        {
            if(curTmp == 1) return answer;
            if(curTmp%2==0) curTmp/=2;
            else curTmp=curTmp*3+1;
            answer++;
        }
        return -1;
    }
}