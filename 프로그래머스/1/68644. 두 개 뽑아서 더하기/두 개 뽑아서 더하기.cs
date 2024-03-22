using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] numbers) {
        var answer = new List<int>();
        for (int i = 0; i < numbers.Length; i++) {
            for (int j = i + 1; j < numbers.Length; j++) {
                answer.Add(numbers[i] + numbers[j]);
            }
        }
        int[] result = answer.Distinct().ToArray();
        Array.Sort(result);
        return result;
    }
}