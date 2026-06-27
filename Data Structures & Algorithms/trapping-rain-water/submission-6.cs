public class Solution {
    public int Trap(int[] height) {
        int res=0;
        for(int i=0;i<height.Length;i++){
            int leftMax = height[i];
            int rightMax = height[i];
            for(int j=0;j<i;j++){
                leftMax = Math.Max(leftMax, height[j]);
            }
            for(int k=i+1;k<height.Length;k++){
                rightMax = Math.Max(rightMax,height[k]);
            }
            res += Math.Min(leftMax,rightMax) - height[i];
        }
        return res;
    }
}
