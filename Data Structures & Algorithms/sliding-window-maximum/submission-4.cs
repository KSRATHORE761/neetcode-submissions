public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        if (nums == null || nums.Length == 0 || k == 0) return new int[0];

        int l = 0, r = 0;
        List<int> res = new List<int>();
        
        // Track the index of the maximum element in the window
        int maxIdx = -1; 

        while (r < nums.Length) {
            // When the sliding window reaches the required size 'k'
            while (r - l + 1 == k) {
                
                // Case 1: The previous maximum is still inside the current window
                if (maxIdx >= l) {
                    // Just compare it with the single new element entering on the right (nums[r])
                    if (nums[r] >= nums[maxIdx]) {
                        maxIdx = r;
                    }
                } 
                // Case 2: The previous maximum just dropped out of the left side (maxIdx < l)
                else {
                    // Lazy Re-scan: We are forced to look through the window to find the new max
                    maxIdx = l;
                    for (int i = l + 1; i <= r; i++) {
                        if (nums[i] >= nums[maxIdx]) {
                            maxIdx = i;
                        }
                    }
                }

                // Add the found maximum to your results list
                res.Add(nums[maxIdx]);
                l++; // Shrink the window from the left
            }
            r++; // Expand the window to the right
        }
        
        return res.ToArray();
    }
}
