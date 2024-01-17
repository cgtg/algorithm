public class Solution {
    public string solution(string phone_number) {
        int length = phone_number.Length;
        return new string('*', length - 4) + phone_number.Substring(length - 4, 4);
    }
}