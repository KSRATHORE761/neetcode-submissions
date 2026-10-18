public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        // total number of rows.
        int m = matrix.Length;
        // total number of cols.
        int n = matrix[0].Length;
        int start = 0, end = (m*n)-1;
        while(start<=end){
            int mid = start + (end-start)/2;
            if(matrix[mid/n][mid%n] < target){
                start = mid+1;
            }
            else if(matrix[mid/n][mid%n] > target){
                end = mid-1;
            }
            else{
                return true;
            }
        }
        return false;
    }
}
