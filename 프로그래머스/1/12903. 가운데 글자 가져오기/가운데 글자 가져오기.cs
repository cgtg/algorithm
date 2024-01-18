public class Solution {
    public string solution(string s) {
        string answer = "";
        int length = s.Length;
        if(length%2 == 0){
            return s.Substring(length / 2 - 1, 2);
        }
        else{
            return s[length/2].ToString();
        }
    }
}