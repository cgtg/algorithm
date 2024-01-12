using System;

public class Solution {
    public int solution(int age) {
        if( age <= 0 || age > 120 ){
            throw new ArgumentOutOfRangeException("age가 제한사항을 벗어났습니다.");
        }
        return 2023 - age;
    }
}