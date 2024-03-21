public class Solution {
    public string[] solution(string[] strings, int n) {
        string[] answer = new string[strings.Length];
        
        //각 문자열의 n번째 글자를 앞으로 더한 문자열을 저장
        for(int i = 0; i < strings.Length; i++)
            answer[i] = (strings[i][n]) + strings[i];
        
        //오름차순 정렬
        for(int i = 0; i < strings.Length; i++){
            for(int j = i + 1; j < strings.Length; j++){
                for(int k = 0; k < answer[0].Length; k++){
                    if(answer[i][k] > answer[j][k]){
                        string temp = answer[i];
                        answer[i] = answer[j];
                        answer[j] = temp;
                        break;
                    }
                    else if(answer[i][k] < answer[j][k]){
                        break;
                    }
                }
            }
        }
        
        //정렬된 문자열에 더했던 n번째 글자를 Substring(1)으로 제거
        for(int i = 0; i < strings.Length; i++)
            answer[i] = answer[i].Substring(1);
        
        return answer;
    }
}