public class Solution {
    public string solution(string s) {
        string answer = "";
        
        string[] str = s.Split(' ');
        
        for(int i = 0; i < str.Length; i++){
            for(int j = 0; j < str[i].Length; j++){
                if(j % 2 == 0){
                    if(str[i][j] > 64 && str[i][j] < 91)
                        answer += str[i][j];
                    else
                        answer += (char)(str[i][j] - 32);
                }
                else{
                    if(str[i][j] > 64 && str[i][j] < 91)
                        answer += (char)(str[i][j] + 32);
                    else
                        answer += str[i][j];
                }
            }
            if(i + 1 != str.Length)
                answer += " ";
        }
        
        return answer;
    }
}