using System;

public class Solution {
    public int solution(int num1, int num2) {
        if (num1 < -50000 || num1 > 50000 || num2 < -50000 || num2 > 50000)
        {
            throw new ArgumentOutOfRangeException("num1 또는 num2가 제한사항을 벗어났습니다.");
        }
        return num1-num2;
    }
}