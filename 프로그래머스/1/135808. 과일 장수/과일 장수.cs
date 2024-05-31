using System;
using System.Linq;

public class Solution {
    public int solution(int k, int m, int[] score) {
        // score를 내림차순으로 정렬
        Array.Sort(score);
        Array.Reverse(score);
        
        // return 시킬 최대 이익 값 초기화
        int answer = 0;
        
        // 상자 생성 후 큰 수부터 입력하여 이익 계산
        for(int i = 0; i < score.Length / m; i++){
            int[] box = new int[m];
            for(int j = 0; j < m; j++){
                box[j] += score[i * m + j];
            }
            answer += box[m - 1] * m;
        }
        
        return answer;
    }
}
