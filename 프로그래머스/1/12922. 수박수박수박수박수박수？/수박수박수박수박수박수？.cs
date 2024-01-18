using System.Text;
public class Solution {
    public string solution(int n) {
        StringBuilder result = new StringBuilder(n);
        for (int i = 0; i < n / 2; i++) {
            result.Append("수박");
        }
        if (n % 2 == 1) {
            result.Append('수');
        }
        return result.ToString();
    }
}