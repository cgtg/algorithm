using System;
using System.Linq;
public class Solution {
    public int[] solution(int[] array, int[,] commands) {
        int[] answer = new int[commands.GetLength(0)];
        for (int l = 0; l < commands.GetLength(0); l++)
        {
            int i = commands[l, 0] - 1;
            int j = commands[l, 1];
            int k = commands[l, 2] - 1;

            int[] tmpArr = array.Skip(i).Take(j - i).ToArray();
            Array.Sort(tmpArr);
            answer[l] = tmpArr[k];
        }
        return answer;
    }
}