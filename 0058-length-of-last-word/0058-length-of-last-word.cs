public class Solution {
    public int LengthOfLastWord(string s) {
        int i = s.Length;
        int l = 0;
        while(i > 0)
        {
            i--;

            if(s[i] != ' ')
                l++;
            else if(l > 0)
                return l;
        }

        return l;
    }
}