using System;

class Solution
{
    public long solution(int price, int money, int count)
    {
        long sum = 0;
        
        for(int i = 1; i <= count; i++)
            sum += i;
        
        if(money >= price * sum)
            return 0;
        else
            return price * sum - money;
    }
}