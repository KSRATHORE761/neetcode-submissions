public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
      Dictionary<int,int> freq = new Dictionary<int,int>();
      foreach(int num in nums){
        freq[num] = freq.GetValueOrDefault(num,0)+1;
      }
    //   List<KeyValuePair<int,int>> lst = new List<KeyValuePair<int, int>>(freq);
    //   lst.Sort((a,b)=> b.Value.CompareTo(a.Value));
    List<int[]> lst = freq.Select(entry => new int[]{entry.Value,entry.Key}).ToList();
    lst.Sort((a,b) => b[0].CompareTo(a[0]));

      int[] res= new int[k];
    //   int i=0;
    //   foreach(KeyValuePair<int,int> pair in lst){
    //     if(i<k){
    //         res[i] = pair.Key;
    //     }
    //     i++;
    //   }
    for(int i=0;i<k;i++){
        if(i<k){
            res[i] = lst[i][1];
        }
    }
      return res;
    }
}
