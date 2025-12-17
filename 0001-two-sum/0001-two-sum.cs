public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> visited = new();
        for(int i = 0; i < nums.Length; i++)
        {
            int num = nums[i];
            int required = target - num;

            if(!visited.TryGetValue(required, out int index))
            {
                visited.TryAdd(num, i);
                continue;
            }
            else
            {
                return new int[] { i, index };
            }
        }

        return [];
    }
}