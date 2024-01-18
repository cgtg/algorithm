using System.Linq;
public class Solution {
    public int[] solution(int[] arr) {
        if(arr.Length <2){
            return new int[]{-1};
        }
        int minVal = arr.Min();
        return arr.Where(x => x != minVal).ToArray();
    }
}