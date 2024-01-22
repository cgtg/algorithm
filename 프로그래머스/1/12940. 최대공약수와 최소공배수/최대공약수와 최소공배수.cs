public class Solution {
    public int[] solution(int n, int m) {
        int gcd = GCD(n,m);
        int lcm = n*m/gcd;
        return new int[] {gcd,lcm};
    }
    
    public int GCD(int a, int b) {
        while (b != 0) {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}