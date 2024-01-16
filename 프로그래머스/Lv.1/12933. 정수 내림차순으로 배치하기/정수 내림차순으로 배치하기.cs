using System;
using System.Linq;
public class Solution {
    public long solution(long n) {
        char[] s=n.ToString().ToCharArray();
        Array.Sort(s, (a,b)=>b.CompareTo(a));
        return long.Parse(string.Concat(s));
    }
}