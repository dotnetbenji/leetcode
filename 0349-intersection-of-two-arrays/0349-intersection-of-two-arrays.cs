public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        List<int> intersection = new();

        int len1 = nums1.Length;
        int len2 = nums2.Length;

        int[] shorter = len1 > len2 ? nums2 : nums1;
        int[] longer =  len1 > len2 ? nums1 : nums2;
        HashSet<int> containedByShorter = new();

        for(int i = 0; i < shorter.Length; i++)
        {
            containedByShorter.Add(shorter[i]);
        }

        for(int i = 0; i < longer.Length; i++)
        {
            int cur = longer[i];
            if(containedByShorter.Contains(cur))
            {
                intersection.Add(cur);
                containedByShorter.Remove(cur);
            }
        }

        return intersection.ToArray();
    }
}