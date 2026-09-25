public class Solution {
    public int Trap(int[] height) {
        int n = height.Length;
        int totalWaterTrap = 0;
        int l=0, r = n-1;
        int leftMax = height[0], rightMax = height[n-1];
        while(l<r){
            if(leftMax<rightMax){
                l++;
                leftMax = Math.Max(leftMax, height[l]);
                totalWaterTrap += leftMax - height[l];
            }
            else{
                r--;
                rightMax = Math.Max(rightMax, height[r]);
                totalWaterTrap +=rightMax - height[r];
            }
        }
        return totalWaterTrap;
    }
}
