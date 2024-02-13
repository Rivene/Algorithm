public class Solution {
    public long solution(int a, int b) {
        long answer = 0;
        
        if(a < b){
            while(a - 1 != b){
                answer += a;
                a++;
            }
        }
        else{
            while(b - 1 != a){
                answer += b;
                b++;
            }
        }
        
        return answer;
    }
}