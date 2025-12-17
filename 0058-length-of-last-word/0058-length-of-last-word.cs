public class Solution {
    public int LengthOfLastWord(string s) {
        int i = s.Length - 1;
        int l = 0;
        bool foundWord = false;
        while(!foundWord || s[i] != ' ')
        {
            if(s[i] != ' ')
            {
                l++;
                foundWord = true;
            }

            i --;
            if(i < 0)
                return l;
        }

        return l;
    }
}