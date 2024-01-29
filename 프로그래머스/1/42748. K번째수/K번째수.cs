using System;
using System.Linq;
public class Solution {
    public int[] solution(int[] array, int[,] commands) {
        int[] answer = new int[commands.GetLength(0)];
        for (int i = 0; i < commands.GetLength(0); i++)
        {
            int start = commands[i, 0] - 1;
            int end = commands[i, 1];
            int j = commands[i, 2] - 1;

            int[] tmpArr = array.Skip(start).Take(end - start).ToArray();
            Array.Sort(tmpArr);
            answer[i] = tmpArr[j];
        }
        return answer;
    }
}