using System;
using System.Collections.Generic;
public class Solution {
    public int solution(int[] ingredient) {
        int answer = 0;
//         string s = String.Join("", ingredient);
//         while(true){
//             string temp = ReplaceFirst(s); //s.Replace("1231","");
//             //Console.WriteLine($"{s} / {temp}");
//             // Console.WriteLine(s);
//             if(temp != s) {
//                 // 변환됨
//                 s=temp;
//                 answer++;
//             }
//             else{
//                 break;
//             }
//         }
        
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
    
    // public string ReplaceFirst(string text)
    // {
    //     int pos = text.IndexOf("1231");
    //     if (pos < 0)
    //     {
    //         return text;
    //     }
    //     return text.Substring(0, pos) + text.Substring(pos + 4);
    // }
}