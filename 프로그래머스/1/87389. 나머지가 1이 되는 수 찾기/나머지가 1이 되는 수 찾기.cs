using System;

public class Solution {
    public int solution(int n) {
        int i;
        for(i = 1; i < n; i++){
            if(n%i==1)
                break;
        }
        return i;
    }
}