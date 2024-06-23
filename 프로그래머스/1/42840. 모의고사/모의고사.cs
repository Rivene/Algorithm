using System;

public class Solution {
    public int[] solution(int[] answers) {
        int[] answers1 = new int[answers.Length];
        int[] answers2 = new int[answers.Length];
        int[] answers3 = new int[answers.Length];
        
        int correct1 = 0;
        int correct2 = 0;
        int correct3 = 0;
        
        // 1번 수포자
        for(int i = 0; i < answers.Length; i++){
            if((i + 1) % 5 == 0){
                if(answers[i] == 5)
                    correct1++;
            }
            else if(answers[i] == (i + 1) % 5)
                correct1++;
        }
        
        // 2번 수포자
        for(int i = 0; i < answers.Length; i++){
            if(i % 2 == 0)
                answers2[i] = 2;
            else if(i % 8 == 1)
                answers2[i] = 1;
            else if(i % 8 == 3)
                answers2[i] = 3;
            else if(i % 8 == 5)
                answers2[i] = 4;
            else if(i % 8 == 7)
                answers2[i] = 5;
            if(answers[i] == answers2[i])
                correct2++;
        }
        
        // 3번 수포자
        for(int i = 0; i < answers.Length; i++){
            if(i % 10 == 0 || i % 10 == 1)
                answers3[i] = 3;
            else if(i % 10 == 2 || i % 10 == 3)
                answers3[i] = 1;
            else if(i % 10 == 4 || i % 10 == 5)
                answers3[i] = 2;
            else if(i % 10 == 6 || i % 10 == 7)
                answers3[i] = 4;
            else if(i % 10 == 8 || i % 10 == 9)
                answers3[i] = 5;
            if(answers[i] == answers3[i])
                correct3++;
        }
        
        int maxIndex = 0;
        int[, ] answer = new int[3, 2]{{1, correct1}, {2, correct2}, {3, correct3}};
        for(int i = 0; i < 3; i++){
            maxIndex = i;
            for(int j = i + 1; j < 3; j++){
                if(answer[maxIndex, 1] < answer[j, 1])
                    maxIndex = j;
            }
            for(int k = 0; k < 2; k++){
                int temp = answer[i, k];
                answer[i, k] = answer[maxIndex, k];
                answer[maxIndex, k] = temp;
            }
        }
        int[] sortAnswer;
        if(answer[0, 1] == answer[1, 1]){
            if(answer[1, 1] == answer[2, 1])
                sortAnswer = new int[3]{answer[0, 0], answer[1, 0], answer[2, 0]};
            else
                sortAnswer = new int[2]{answer[0, 0], answer[1, 0]};
        }
        else
            sortAnswer = new int[1]{answer[0, 0]};
        
        return sortAnswer;
    }
}