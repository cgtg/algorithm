using System.Linq;
public class Solution {
    public int solution(int[] numbers) {
        return Enumerable.Range(0, 10).Except(numbers).Sum();
    }
}