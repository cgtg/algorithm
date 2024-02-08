using System;
using System.Linq;
class Solution
{
    public int solution(int[] nums)
    {
        int answer = 0;
        // 에라토스테네스의 체
        bool[] isPrime = Enumerable.Repeat(true, 3001).ToArray();
        for (int i = 2; i * i <= 3000; i++)
        {
            if (isPrime[i])
            {
                for (int j = i * i; j <= 3000; j += i)
                {
                    isPrime[j] = false;
                }
            }
        }

        for (int i = 0; i < nums.Length - 2; i++) {
            for (int j = i + 1; j < nums.Length - 1; j++) {
                for (int k = j + 1; k < nums.Length; k++) {
                    int sum = nums[i] + nums[j] + nums[k];
                    if (isPrime[sum]) {
                        answer++;
                    }
                }
            }
        }

        return answer;
    }
}