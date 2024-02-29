using System;
using System.Linq;
public class Solution {
    public int solution(int n, int[] lost, int[] reserve) {
        int[] students = new int[n]; // 0으로 초기화됨. 배열은 0부터 시작
        
        for (int i = 0; i < lost.Length; i++) // 잃어버린사람
            students[lost[i] - 1]--;
        for (int i = 0; i < reserve.Length; i++) // 여유분
            students[reserve[i] - 1]++;
        
        for (int i = 0; i < students.Length; i++) {
            if (students[i] == -1) // 잃어버린사람 찾아서
            {
                // 앞뒤 남은거 확인
                if (i - 1 >= 0 && students[i - 1] == 1) {
                    students[i - 1]--;
                    students[i]++;
                } else if (i + 1 < students.Length && students[i + 1] == 1) {
                    students[i + 1]--;
                    students[i]++;
                }
            }
        }
        
        return students.Count(s => s >= 0);
    }
}