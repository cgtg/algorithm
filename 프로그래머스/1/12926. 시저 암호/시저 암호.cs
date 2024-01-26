using System.Text;
public class Solution {
    public string solution(string s, int n) {
        StringBuilder answer = new StringBuilder();
        foreach (char c in s)
        {
            if (char.IsLetter(c))
            {
                char baseChar = char.IsUpper(c) ? 'A' : 'a';
                char encryptedChar = (char)(((c - baseChar + n) % 26) + baseChar);
                answer.Append(encryptedChar);
            }
            else
            {
                answer.Append(c);
            }
        }

        return answer.ToString();
    }
}