public class Solution {
    public string solution(string s) {
        string answer = "";
        char[] charArray = new char[s.Length];
        
        for(int i = 0; i < s.Length; i++){
            charArray[i] = s[i];
        }
        
        for(int i = 0; i < s.Length; i++){
            for(int j = 0; j < s.Length - 1; j++){
                if((int)charArray[j] < (int)charArray[j+1]){
                    char temp = charArray[j];
                    charArray[j] = charArray[j + 1];
                    charArray[j + 1] = temp;
                }
            }
        }
        
        for(int i = 0; i < s.Length; i++)
            answer += charArray[i];
        
        return answer;
    }
}