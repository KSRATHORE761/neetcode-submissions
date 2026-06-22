public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        List<List<int>> list = new List<List<int>>();
        Array.Sort(nums);
        for (int i = 0; i < nums.Length; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1]) continue;
            int j = i + 1;
            int k = nums.Length - 1;
            int sum = -nums[i];
            while (j < k)
            {
                if (nums[j] + nums[k] < sum) j++;
                else if (nums[j] + nums[k] > sum) k--;
                else
                {
                    list.Add(new List<int> { nums[i], nums[j], nums[k] });
                    j++; k--;
                    while (j < k && nums[j] == nums[j - 1]) j++;
                }
            }

        }
        return list;
    }
}
