using System;

public class Solution {
    public int[] solution(int k, int[] score) {
        int[] answer = new int[score.Length];
        
        for(int day = 0; day < score.Length; day++){
            for(int n = 0; n < day; n++)
                for(int i = 0; i < day; i++)
                    if(score[i] < score[i + 1]){
                        int temp = score[i];
                        score[i] = score[i + 1];
                        score[i + 1] = temp;
                    }
            if(day < k)
                answer[day] = score[day];
            else
                answer[day] = score[k - 1];
        }

        return answer;
    }
}