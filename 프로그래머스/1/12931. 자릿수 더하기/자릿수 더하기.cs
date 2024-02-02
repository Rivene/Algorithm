using System;

public class Solution {
    int[] num = new int[10];
    int x = 0;
    
   public int solution(int n) {
        if(n/10>0){
            num[x] = n%10;
            n/=10;
            x++;
            solution(n);
        }else{
            num[x] = n%10;
            x=0;
        }
       int sum=0;
       for(int i=0;i<10;i++){
           sum+=num[i];
       }
       return sum;
    }
}