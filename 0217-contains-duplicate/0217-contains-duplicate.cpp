class Solution {
public:
    bool containsDuplicate(vector<int>& nums) {

        int numsLength = nums.size();
        std::unordered_set<int> mySet{};

        int num = 0;
        for(int i = 0; i < numsLength; i++)
        {
            num = nums[i];
            if(mySet.contains(num))
                return true;

            mySet.insert(num);
        }

        return false;
    }
};