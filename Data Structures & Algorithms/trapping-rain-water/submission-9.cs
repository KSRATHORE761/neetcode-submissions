public class Solution {
    public int Trap(int[] height) {
        int n = height.Length;
        int res=0;
        int l=0,r=n-1;
        int leftMax = height[l];
        int rightMax = height[r];
        while(l<r){
            if(leftMax<rightMax){
                l++;
                leftMax = Math.Max(height[l],leftMax);
                res += leftMax - height[l];
            }
            else{
                r--;
                rightMax = Math.Max(height[r],rightMax);
                res +=rightMax-height[r];
            }
        }
        return res;
    }
}
