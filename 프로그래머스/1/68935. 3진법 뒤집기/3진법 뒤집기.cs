using System;

public class Solution {
    public int solution(int n) {
        int answer = n;
        int num = 1;
        int length = 0;
        
        while(answer > 2){
            answer /= 3;
            length++;
        }
        answer = 0;
        
        for(int i = 0; i < length; i++){
            num *= 3;
        }
        
        while(n > 0){
            answer += n % 3 * num;
            n /= 3;
            num /= 3;
        }
        
        return answer;
    }
}