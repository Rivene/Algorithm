using System;

public class Solution {
    public int solution(int a, int b, int n) {
        int answer = 0;
        int rest = 0;
        
        while(n >= a){
            answer += n / a * b;
            n -= n / a * (a - b);
        }
        
        return answer;
    }
}