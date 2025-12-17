public class Solution {
    public int Reverse(int x) {

        int sign = x < 0 ? -1 : 1;

        if(x == int.MinValue)
            return 0;

        int pos = Math.Abs(x);

        int reverse = 0;
        while(pos > 0)
        {
            int digit = pos % 10;
            if (reverse > (int.MaxValue - digit) / 10)
                return 0;

            reverse = reverse * 10 + digit;
            pos /= 10;
        }

        return reverse * sign;
    }
}