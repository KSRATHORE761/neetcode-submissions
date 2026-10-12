public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        int l=0,r=0;
        List<int> res = new List<int>();
        // Track the index of the maximum element in the window
        int maxIndex = -1;
        while(r<nums.Length){
            while(r-l+1 == k){
                // Case 1: The previous maximum is still inside the current window
                if(maxIndex >=l){
                    // Just compare it with the single new element entering on the right (nums[r])
                    if(nums[r] >= nums[maxIndex]){
                        maxIndex = r;
                    }
                }
                // Case 2: The previous maximum just dropped out of the left side (maxIdx < l)
                else{
                    maxIndex = l;
                    // Lazy Re-scan: We are forced to look through the window to find the new max
                    for(int i=l+1; i<=r;i++){
                        if(nums[i] > nums[maxIndex]){
                            maxIndex = i;
                        }
                    }
                }
                res.Add(nums[maxIndex]);
                l++;
            }
            r++;
        }
        return res.ToArray();
    }
}
