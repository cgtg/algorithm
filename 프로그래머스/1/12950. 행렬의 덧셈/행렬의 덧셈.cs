public class Solution {
    public int[,] solution(int[,] arr1, int[,] arr2) {
        int rows = arr1.GetLength(0);
        int columns = arr1.GetLength(1);
        int[,] answer = new int[rows, columns];
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < columns; j++) {
                answer[i, j] = arr1[i, j] + arr2[i, j];
            }
        }
        return answer;
    }
}