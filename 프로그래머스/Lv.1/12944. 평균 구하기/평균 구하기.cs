using System;
using System.Linq;

public class Solution {
    public double solution(int[] arr) {
        if (arr.Length > 100 || arr.Length <= 0)
        {
            throw new ArgumentOutOfRangeException("arr의 길이가 제한사항을 벗어났습니다.");
        }
        if(arr.Any(x=> x<-10000 || x>10000)){
            throw new ArgumentOutOfRangeException("arr에 원소가 범위를 벗어났습니다.");
        }

        return arr.Average();
    }
}