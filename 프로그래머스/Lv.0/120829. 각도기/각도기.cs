using System;

public class Solution {
    public int solution(int angle) {
        if (angle <= 0 || angle > 180)
        {
            throw new ArgumentOutOfRangeException("angle이 제한사항을 벗어났습니다.");
        }
        if(angle == 90){
            return 2;
        }
        else if(angle == 180){
            return 4;
        }
        else if(angle<90){
            return 1;
        }
        else {
            return 3;
        }
    }
}