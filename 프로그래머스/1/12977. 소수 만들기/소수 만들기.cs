using System;

class Solution
{
    public int solution(int[] nums)
    {
        int answer = 0;
        int complex;
        
        for(int i = 0; i < nums.Length; i++){
            for(int j = i + 1; j < nums.Length; j++){
                for(int k = j + 1; k < nums.Length; k++){
                    complex = 0;
                    for(int cases = nums[i] + nums[j] + nums[k] - 1; cases > 1; cases--){
                        if((nums[i] + nums[j] + nums[k]) % cases == 0){
                            complex++;
                            break;
                        }
                    }
                    if(complex == 0)
                        answer++;
                }
            }
        }
        

        // [실행] 버튼을 누르면 출력 값을 볼 수 있습니다.
        //Console.Write(complex);

        return answer;
    }
}