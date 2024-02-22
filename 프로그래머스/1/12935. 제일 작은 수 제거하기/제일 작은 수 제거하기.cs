public class Solution {
    public int[] solution(int[] arr) {
        if(arr.Length == 1)
            return new int[] {-1};
        int[] answer = new int[arr.Length - 1];
        int min = arr[0];
        
        for(int i = 0; i < arr.Length; i++){
            if(arr[i] < min)
                min = arr[i];
        }
        
        for(int i = 0, j = 0; i < arr.Length; i++){
            if(arr[i] != min){
                answer[j] = arr[i];
                j++;
            }
        }
        
        return answer;
    }
}