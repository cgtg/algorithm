using System;
public class Solution {
    public string solution(string s) {
        char[] charArray = s.ToCharArray();
        Array.Sort(charArray, (a, b) => b.CompareTo(a));
        return new string(charArray);
    }
}