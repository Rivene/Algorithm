using System;

public class Solution {
    public int solution(string[] babbling) {
        int answer = 0;
        string[] talking = new string[] { "aya", "ye", "woo", "ma" };

        // babbling 중 한 원소의 문자열에서 talking 중 한 원소의 문자열을 탐색
        // 1. 두 번 연속 사용된 talking 존재 시 answer을 증가시키지 않도록 처리
        // 2. talking과 일치하는 부분을 공백으로 변경
        // 3. 발음 가능 시 babbling의 원소가 공백이기 때문에 answer 값 증가
        for (int i = 0; i < babbling.Length; i++){
            for (int j = 0; j < talking.Length; j++){
                string doubleTalking = talking[j] + talking[j];
                babbling[i] = babbling[i].Replace(doubleTalking, "X").Replace(talking[j], " ");
            }
            if (babbling[i].Trim() == "")
                answer++;
        }
        
        return answer;
    }
}