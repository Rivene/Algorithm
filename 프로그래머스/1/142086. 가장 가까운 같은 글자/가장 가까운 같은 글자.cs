using System;

public class Solution {
    public int[] solution(string s) {
        int[] answer = new int[s.Length];
        
        answer[0] = -1;
        
        for(int i = 1; i < s.Length; i++){
            for(int j = 0; j < i; j++){
                if(s[i] == s[j])
                    answer[i] = i - j;
            }
            
            if(answer[i] == 0)
                answer[i] = -1;
        }
        
        return answer;
    }
}