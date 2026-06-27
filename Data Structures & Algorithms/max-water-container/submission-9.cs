public class Solution {
    public int MaxArea(int[] heights) {
        int maxWater = 0;
        for(int i=0;i<heights.Length;i++){
            int currentWater = 0;
            for(int j=i+1;j<heights.Length;j++){
               currentWater = Math.Max(currentWater,(j-i) * Math.Min(heights[i],heights[j]));
            }   
            maxWater = Math.Max(maxWater,currentWater);
        }
        return maxWater;
    }
}
