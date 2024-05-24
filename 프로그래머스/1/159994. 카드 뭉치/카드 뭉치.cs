using System;

public class Solution {
    public string solution(string[] cards1, string[] cards2, string[] goal) {
        int index1 = 0, index2 = 0; // cards1과 cards2의 현재 인덱스를 추적합니다.

    foreach (var word in goal)
    {
        bool found = false;

        // cards1에서 현재 단어를 찾습니다.
        while (index1 < cards1.Length && !found)
        {
            if (cards1[index1] == word)
            {
                index1++; // 단어를 찾았으므로 다음 단어로 넘어갑니다.
                found = true;
            }
            else
            {
                // cards1에 단어가 없으면 더 이상 진행할 수 없습니다.
                break;
            }
        }

        // cards1에 단어가 없고 cards2에서 현재 단어를 찾습니다.
        if (!found)
        {
            while (index2 < cards2.Length && !found)
            {
                if (cards2[index2] == word)
                {
                    index2++; // 단어를 찾았으므로 다음 단어로 넘어갑니다.
                    found = true;
                }
                else
                {
                    // cards2에도 단어가 없으면 더 이상 진행할 수 없습니다.
                    break;
                }
            }
        }

        // 원하는 단어를 찾지 못했다면 "No"를 반환합니다.
        if (!found) return "No";
    }

    // 모든 단어를 찾았다면 "Yes"를 반환합니다.
    return "Yes";
    }
}