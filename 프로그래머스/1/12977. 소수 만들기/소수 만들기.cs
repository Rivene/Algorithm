using System;

class Solution
{
    public int solution(int[] nums)
    {
        int answer = 0;  // 리턴할 값 : 소수되는 경우
        int complex = 0; // 합성수인 경우 증가
        
        for(int i = 0; i < nums.Length; i++)
            for(int j = i + 1; j < nums.Length; j++)
                for(int k = j + 1; k < nums.Length; k++){
                    complex = 0;
                    for(int cases = nums[i] + nums[j] + nums[k] - 1; cases > 1; cases--)
                        if((nums[i] + nums[j] + nums[k]) % cases == 0)
                            complex++;
                    if(complex == 0)
                        answer++;
                }
        
        return answer;
    }
}