using System;
using System.Linq;

public class Solution {
    public double solution(int[] numbers) {
        if (numbers.Length > 100 || numbers.Length <= 0 || numbers.Max() > 1000 || numbers.Min() < 0 )
        {
            throw new ArgumentOutOfRangeException("numbers이 제한사항을 벗어났습니다.");
        }
        
        return numbers.Average();
    }
}