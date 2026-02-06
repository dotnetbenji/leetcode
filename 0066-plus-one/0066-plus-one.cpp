class Solution {
public:
    vector<int> plusOne(vector<int>& digits) {
        int len = digits.size();
        for(int i = len; i > 0; i--)
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

        digits[0] = 1;
        for(int i = 1; i < len; i++)
        {
            digits[i] = 0;
        }
        digits.push_back(0);
        return digits;
    }
};