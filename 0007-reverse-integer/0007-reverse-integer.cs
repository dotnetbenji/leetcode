public class Solution {
    public int Reverse(int x) {

        int sign = x < 0 ? -1 : 1;

        try
        {
            int pos = Math.Abs(x);

            int reverse = 0;
            while(pos > 0)
            {
                checked
                {
                    reverse = reverse * 10 + (pos % 10);
                }
                pos /= 10;
            }

            return reverse * sign;
        }
        catch(OverflowException)
        {
            return 0;
        }
    }
}