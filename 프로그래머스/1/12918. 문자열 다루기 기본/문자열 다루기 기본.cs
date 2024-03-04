public class Solution {
    public bool solution(string s) {
        
        if(!(s.Length == 4 || s.Length == 6))
            return false;
        
        for(int i = 0; i < s.Length; i++)
            if(!int.TryParse(s[i].ToString(), out int num))
                return false;
        
        return true;
    }
}