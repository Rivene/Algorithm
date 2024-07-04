using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public string solution(string X, string Y) {
        /// 1. 문자열 X, Y에 각 숫자가 몇 번 등장하는지 저장할 정수 배열 생성
        int[] countX = new int[10];
        int[] countY = new int[10];
        
        /// 2. 문자열 X, Y의 각 문자에 대해 해당하는 숫자 등장 횟수 증가
        foreach (char c in X)
            countX[Int32.Parse(c.ToString())]++; // 해당 문자를 문자열로 변경 후 정수로 변경하는 방식
        foreach (char c in Y)
            countY[c - '0']++; // 해당 문자와 '0'의 아스키 코드 값의 차이를 이용하는 방식
        
        /// 3. 9부터 0까지의 숫자에 대해 해당 숫자가 X, Y에 동시 등장 횟수를 계산하고 result 리스트에 추가
        List<int> result = new List<int>();
        for (int i = 9; i >= 0; i--){
            result.AddRange(Enumerable.Repeat(i, Math.Min(countX[i], countY[i])));
        }
        
        /// 4-1. result 리스트가 비어있으면 -1을, 모든 요소가 0이면 0을 반환
        if (result.Count == 0)
            return "-1";
        if (result.All(d => d == 0))
            return "0";
        
        /// 4-2. result 리스트의 모든 요소를 문자열로 변환하여 연결 후 반환
        return string.Join("", result);
    }
}
