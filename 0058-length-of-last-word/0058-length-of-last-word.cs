public class Solution {
    public int LengthOfLastWord(string s) {
        int i = s.Length;
        int l = 0;
        bool foundWord = false;
        while(i > 0)
        {
            i--;

            if(s[i] != ' ')
            {
                l++;
                continue;
            }

            if(l > 0)
                break;
        }

        return l;
    }
}