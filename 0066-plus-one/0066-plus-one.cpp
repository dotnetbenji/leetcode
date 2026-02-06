class Solution {
public:
    vector<int> plusOne(vector<int>& digits) {
        int len = digits.size();
        if(digits.back() < 9)
        {
            digits[len-1]++;
            return digits;
        }

        for(int i = len-1; i > 0; i--)
        {
            if(digits[i-1] < 9)
            {
                digits[i-1]++;
                for(int j = i; j < len; j++)
                {
                    digits[j] = 0;
                }
                return digits;
            }
        }

        digits.insert(digits.begin(), 1);
        for(int i = 1; i < len+1; i++)
        {
            digits[i] = 0;
        }
        return digits;
    }
};