public class Solution {
    public int MaximumGap(int[] nums) {
        if (nums.Length < 2)
            return 0;

        Array.Sort(nums);

        int i = 0;
        int maxDiff = 0;
        do
        {
            int diff = nums[i+1] - nums[i];
            if(diff > maxDiff)
                maxDiff = diff;
            
            i++;
        } while (i < nums.Length - 1);

        return maxDiff;
    }
}