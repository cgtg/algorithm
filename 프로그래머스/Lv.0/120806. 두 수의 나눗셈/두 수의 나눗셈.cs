using System;

public class Solution {
    public int solution(int num1, int num2) {
        if (num1 <= 0 || num1 > 100 || num2 <= 0 || num2 > 100)
        {
            throw new ArgumentOutOfRangeException("num1 또는 num2가 제한사항을 벗어났습니다.");
        }
        return num1*1000/num2;
    }
}