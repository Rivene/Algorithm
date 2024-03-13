using System;

public class Solution {
    public int solution(int[,] sizes) {
        int big0 = 0;
        int big1 = 0;
        
        for(int i = 0; i < sizes.GetLength(0); i++){
            if(sizes[i, 0] > sizes[i, 1]){
                int temp = sizes[i, 0];
                sizes[i, 0] = sizes[i, 1];
                sizes[i, 1] = temp;
            }
            if(sizes[i, 0] > big0)
                big0 = sizes[i, 0];
            if(sizes[i, 1] > big1)
                big1 = sizes[i, 1];
        }
        
        
        return big0 * big1;
    }
}