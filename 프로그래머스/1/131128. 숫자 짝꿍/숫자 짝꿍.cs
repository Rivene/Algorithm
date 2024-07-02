using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public string solution(string X, string Y) {
        var countX = new int[10];
        var countY = new int[10];
        
        foreach (var c in X) countX[c - '0']++;
        foreach (var c in Y) countY[c - '0']++;
        
        var result = new List<int>();
        for (int i = 9; i >= 0; i--) {//[^1^][1]
            result.AddRange(Enumerable.Repeat(i, Math.Min(countX[i], countY[i])));
        }
        
        if (result.Count == 0) return "-1";
        if (result.All(d => d == 0)) return "0";
        
        return string.Join("", result);
    }
}
