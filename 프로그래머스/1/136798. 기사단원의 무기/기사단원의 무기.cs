using System;

public class Solution {
    public int solution(int number, int limit, int power) {
        int answer = 0;
        int count;
        
        for(int i = 1; i <= number; i++){
            count = 0;
            
            // 모든 약수 검색 시 시간초과로 인해 제곱근 전까지만 구하고 두 배로 계산
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