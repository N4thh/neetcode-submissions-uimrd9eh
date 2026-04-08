public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int m = matrix.Length; 
        int n = matrix[0].Length; 
    
        int top = 0, bot = m -1; 
        int row = 0; 
        while(top <= bot)
        { 
             int mid = top + (bot-top)/2;
             if(matrix[mid][0] <= target && target <= matrix[mid][n-1])
             { 
                row = mid;
                break; 
             }
             else if (matrix[mid][0] < target) top = mid +1; 
             else bot = mid -1; 
        }

        int left =0, right = n-1; 
        while(left <= right)
        { 
            int mid = left + (right - left)/2; 
            if(matrix[row][mid] == target) return true; 
            else if(matrix[row][mid] < target) left = mid +1; 
            else right = mid -1;
        }
        return false;
    }
}