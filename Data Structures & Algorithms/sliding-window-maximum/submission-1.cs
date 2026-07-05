public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        int l=0,r=0;
        List<int> res = new List<int>();
        while(r<nums.Length){
            while(r-l+1 == k){
                int windowMaxValue = int.MinValue;
                for(int i=l; i<=r;i++){
                    windowMaxValue = Math.Max(windowMaxValue, nums[i]);
                }
                res.Add(windowMaxValue);
                l++;
            }
            r++;
        }
        return res.ToArray();
    }
}
