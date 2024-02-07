using System;
public class Solution {
    public long solution(long n) {
        long answer;
        
        // n을 곧장 char형태로 변환해서 새로운 char 배열에 저장함
        char[] temp = n.ToString().ToCharArray();
        
        // 배열을 오름차순으로 정렬함
        Array.Sort(temp);
        
        // 배열을 뒤집는다 = 내림차순으로 바뀜
        Array.Reverse(temp);
        
        // temp배열을 문자열로 만든뒤에 long형태로 변환한다.
        // long이므로 ToInt32가 아니라 64다. 헷갈린다면 그냥 long.Parse를 쓰자.
        answer = Convert.ToInt64(new string(temp));
        
        // 정답을 리턴함
        return answer;
    }
}