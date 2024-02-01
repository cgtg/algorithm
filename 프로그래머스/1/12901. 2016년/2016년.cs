using System;
public class Solution {
    public string solution(int a, int b) {
        string[] ddd = {"FRI","SAT","SUN","MON","TUE","WED","THU"};
        DateTime date1 = new DateTime(2016, 1, 1);
        DateTime date2 = new DateTime(2016, a, b);
        TimeSpan difference = date2 - date1;
        return ddd[difference.Days%7];
    }
}