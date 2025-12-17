public class Solution {
    public int Reverse(int x) {

        bool negative = x < 0;

        char[] strArr = negative 
            ? x.ToString().Substring(1).ToCharArray()
            : x.ToString().ToCharArray();

        Array.Reverse(strArr);
        string mod = negative ? "-" : "";
        string reversed = $"{mod}{string.Join("", strArr)}";

        try
        {
            return int.Parse(reversed);
        }
        catch (OverflowException)
        {
            return 0;
        }
    }
}