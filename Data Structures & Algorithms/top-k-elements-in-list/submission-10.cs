public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
      Dictionary<int,int> freq = new Dictionary<int,int>();
      foreach(int num in nums){
        freq[num] = freq.GetValueOrDefault(num,0)+1;
      }
      List<KeyValuePair<int,int>> lst = new List<KeyValuePair<int, int>>(freq);
      lst.Sort((a,b)=> b.Value.CompareTo(a.Value));

      int[] res= new int[k];
      int i=0;
      foreach(KeyValuePair<int,int> pair in lst){
        if(i<k){
            res[i] = pair.Key;
        }
        i++;
      }
      return res;
    }
}
