using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int[] solution(int k, int[] score) {
         List<int> answer = new List<int>();
         List<int> tmp = new List<int>();
         for (int i = 0; i < score.Length; i++)
         {
             tmp.Add(score[i]);
             tmp.Sort((x, y) => y.CompareTo(x));
             if (tmp.Count > k)
             {
                 tmp.RemoveAt(k);
             }
             answer.Add(tmp.Take(k).Last());
         }
         return answer.ToArray();
    }
}