using System;

public class Solution {
    public string solution(int a, int b) {
        DateTime date = new DateTime(2016, a, b);
        
        string dayOfWeek = date.DayOfWeek.ToString().ToUpper().Substring(0, 3);
        
        return dayOfWeek;
    }
}