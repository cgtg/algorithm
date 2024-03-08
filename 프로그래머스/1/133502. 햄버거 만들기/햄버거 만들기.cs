using System;
using System.Collections.Generic;
public class Solution {
    public int solution(int[] ingredient) {
        int answer = 0;
        Stack<int> stack = new Stack<int>();
        foreach(int item in ingredient) {
            stack.Push(item);
            if(stack.Count >= 4) {
                int fth = stack.Pop();
                int trd = stack.Pop();
                int snd = stack.Pop();
                int fst = stack.Pop();

                if(fst == 1 && snd == 2 && trd == 3 && fth == 1) {
                    answer++;
                } else {
                    stack.Push(fst);
                    stack.Push(snd);
                    stack.Push(trd);
                    stack.Push(fth);
                }
            }
        }
        return answer;
    }
}