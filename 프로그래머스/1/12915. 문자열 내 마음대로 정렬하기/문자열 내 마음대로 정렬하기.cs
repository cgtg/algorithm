using System.Linq;
public class Solution {
    public string[] solution(string[] strings, int n) {
        return strings.OrderBy(str => str[n]).ThenBy(str => str).ToArray();
    }
}