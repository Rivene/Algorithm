public class Solution {
    public int[] solution(int[] arr, int divisor) {
        int length = 0;
        int count = 0;
        
        for(int i = 0; i < arr.Length; i++)
            if(arr[i] % divisor == 0)
                length++;
        
        if(length == 0)
            return new int[] {-1};
        
        int[] answer = new int[length];
        
        for(int i = 0; i < arr.Length; i++)
            if(arr[i] % divisor == 0){
                answer[count] = arr[i];
                count++;
            }

        for(int i = 0; i < length; i++){
            for(int j = i + 1; j < length; j++){
                if(answer[i] > answer[j]){
                    int temp = answer[j];
                    answer[j] = answer[i];
                    answer[i] = temp;
                }
            }
        }
        
        return answer;
    }
}