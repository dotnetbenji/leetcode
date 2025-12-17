public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for(int i = 0; i < nums.Length; i++)
        {
            int required = target - nums[i];

            int reqTargetIndex = BinSearch(nums, required, i);

            if(reqTargetIndex == -1)
                continue;

            return reqTargetIndex > i
                ? new int[] {i+1, reqTargetIndex+1}
                : new int[] {reqTargetIndex+1, i+1};
        }

        return [];
    }

    public int BinSearch(int[] nums, int target, int firstIndex) 
    {
        int index = nums.Length/2;
        int min = 0;
        int max = nums.Length-1;

        while(nums[index] != target || index == firstIndex)
        {
            if(target > nums[index])
            {
                min = index;
                index += (int)Math.Ceiling((max-index)/2f);
                if(index == min)
                    return -1;
            }
            else
            {
                max = index;
                index -= (int)Math.Floor((index-min)/2f);
                if(index == max)
                    return -1;
            }
        }

        return index;
    }
}