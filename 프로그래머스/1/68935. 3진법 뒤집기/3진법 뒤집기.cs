using System;
using System.Collections.Generic;
public class Solution {
    public int solution(int n) {
        int answer = 0;
        List<int> list = new List<int>();
        while(n > 0){
            list.Add(n%3);
            n/=3;
        }
        
        int pow = 1;
        for(int i=list.Count-1;i>=0;i--){
            answer += list[i]*pow;
            pow*=3;
        }
        return answer;
    }
}