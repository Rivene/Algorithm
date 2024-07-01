using System;

public class Solution {
    public int solution(int number, int limit, int power) {
        int answer = 0;
        int count;
        
        for(int i = 1; i <= number; i++){
            count = 0;
            for(int num = 1; num * num <= i; num++){
                if(i % num == 0){
                    if(i / num == num)
                        count++;
                    else
                        count += 2;
                }
            }
            if(count > limit)
                answer += power;
            else
                answer += count;
        }
        
        return answer;
    }
}