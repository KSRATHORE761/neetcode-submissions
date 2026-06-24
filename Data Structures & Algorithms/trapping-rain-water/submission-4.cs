public class Solution {
    public int Trap(int[] height) {
        if(height == null || height.Length==0)return 0;

        int n = height.Length;
        int maxWaterTrapped = 0;
        for(int i=0;i<n;i++){
            // finding maxixmum element on left of i;
            int leftMax = height[i];
            for(int j=0; j<i;j++){
                leftMax = Math.Max(leftMax, height[j]);
            }
            //finding the maximum on right of i;
            int rightMax = height[i];
            for(int k = i+1;k<n;k++){
                rightMax=  Math.Max(rightMax,height[k]);
            }
            maxWaterTrapped += Math.Min(leftMax, rightMax) - height[i];
        }
        return maxWaterTrapped;
    }
}
