using System;

public class Solution {
    public int[] solution(int[] lottos, int[] win_nums) {
        int[] answer = new int[2];
        int count_0 = 0;
        int count_correctNum = 0;
        
        // 0의 개수 파악
        for(int i = 0; i < 6; i++){
            if(lottos[i] == 0)
                count_0++;
        }
        
        // 일치하는 숫자 파악
        for(int i = 0; i < 6; i++){
            for(int j = 0; j < 6; j++){
                if(lottos[i] == win_nums[j])
                    count_correctNum++;
            }
        }
        
        // 7에서 일치하는 수의 개수만큼 뺌
        answer[0] = 7 - (count_correctNum + count_0);
        answer[1] = 7 - count_correctNum;
        
        // 최저 순위가 6위이므로 7위인 경우 1감소
        if(answer[0] == 7)
            answer[0]--;
        if(answer[1] == 7)
            answer[1]--;
        
        return answer;
    }
}