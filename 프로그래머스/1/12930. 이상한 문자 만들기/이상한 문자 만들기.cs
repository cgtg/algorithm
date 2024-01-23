using System.Text;
public class Solution {
    public string solution(string s) {
        string[] words = s.Split(' ');
        StringBuilder answer = new StringBuilder();
        foreach (string word in words) {
            for (int i = 0; i < word.Length; i++) {
                answer.Append(i % 2 == 0 ? char.ToUpper(word[i]) : char.ToLower(word[i]));
            }
            answer.Append(' ');
        }
        answer.Length--;
        return answer.ToString();
    }
}