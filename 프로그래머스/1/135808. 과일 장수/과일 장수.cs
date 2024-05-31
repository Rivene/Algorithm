using System;
using System.Linq;

public class Solution {
    public int solution(int k, int m, int[] score) {
        // 점수를 내림차순으로 정렬합니다.
        Array.Sort(score);
        Array.Reverse(score);
        
        int answer = 0;
        for(int i = 0; i < score.Length / m; i++){
            int[] box = new int[m];
            for(int j = 0; j < m; j++){
                box[j] += score[j + i * m];
            }
            answer += box[m - 1] * m;
        }
        
        return answer;
    }
}
