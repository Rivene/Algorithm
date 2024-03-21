using System;

public class Solution {
    public int[] solution(int[] array, int[,] commands) {
    int[] answer = new int[commands.GetLength(0)];

    for (int i = 0; i < commands.GetLength(0); i++) {
        int start = commands[i, 0] - 1;
        int end = commands[i, 1] - 1;
        int k = commands[i, 2] - 1;

        int[] tempArray = new int[end - start + 1];
        Array.Copy(array, start, tempArray, 0, end - start + 1);
        Array.Sort(tempArray);

        answer[i] = tempArray[k];
    }

    return answer;
}
}