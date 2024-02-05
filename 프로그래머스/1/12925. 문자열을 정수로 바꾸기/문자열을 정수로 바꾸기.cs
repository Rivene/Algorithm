public class Solution {
    public int solution(string s) {
        int answer = 0;
        if(s.Substring(0,1)=="-"){
            answer = -int.Parse(s.Substring(1));
        }else{
            answer = int.Parse(s.Substring(0));
        }
        return answer;
    }
}