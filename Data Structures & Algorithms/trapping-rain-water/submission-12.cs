public class Solution {
    public int Trap(int[] height) {
        int n = height.Length;
        int totalWaterTrap = 0;
        int left = 0, right=n-1;
        int leftMax = height[left];
        int rightMax = height[right];
        while(left<right){
            if(leftMax < rightMax){
                left++;
                leftMax = Math.Max(leftMax, height[left]);
                totalWaterTrap += leftMax - height[left];
            }
            else{
                right--;
                rightMax = Math.Max(rightMax, height[right]);
                totalWaterTrap += rightMax - height[right];
            }
        }
        return totalWaterTrap;
    }
}
