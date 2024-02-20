using System;

public class Solution {
    public int solution(int[] numbers) {
        int sum = 0;
        
        for(int i = 0; i < numbers.Length; i++)
            sum += numbers[i];
        
        return 45 - sum;
    }
}