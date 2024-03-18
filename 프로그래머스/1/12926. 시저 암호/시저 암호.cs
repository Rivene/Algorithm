public class Solution {
    public string solution(string s, int n) {
        string answer = "";
        
        for(int i = 0; i < s.Length; i++){
            if(s[i] != ' '){
                if(s[i] + n > 90 && s[i] < 91 || s[i] + n > 122)
                    answer += (char)(s[i] + n - 26);      
                else
                    answer += (char)(s[i] + n);
            }
            else
                answer += ' ';
        }
        
        return answer;
    }
}