public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        List<List<int>> res= new List<List<int>>();
        int n=nums.Length;
        for(int i=0;i<n;i++){
            if(i>0 && nums[i] == nums[i-1]) continue;
            int j=i+1;
            int k=n-1;
            int target = -nums[i];
            while(j<k){
                if(nums[j]+nums[k]<target){
                    j++;
                }
                else if(nums[j]+nums[k]>target){
                    k--;
                }
                else{
                    res.Add(new List<int> {nums[i],nums[j],nums[k]});
                    j++;
                    k--;
                    while(j<k && nums[j] == nums[j-1])j++;
                }
            }
        }
        return res;
    }
}
