using System;

class Solution
{
    public long solution(int price, int money, int count)
    {
        long totalCost = (long)count * price * (count + 1) / 2;
        long requiredMoney = totalCost - money;
        return requiredMoney > 0 ? requiredMoney : 0;
    }
}