public class Solution {
    public int MaxArea(int[] heights) {
        int left = 0, right = heights.Length -1; 
        int maxVal = 0;
        while (left < right)
        { 
            int area = (right -left) * Math.Min(heights[left], heights[right]);
             maxVal = Math.Max(maxVal,area); 

            if(heights[left] < heights[right]) left ++; 
            else {right --;} 
        }
        return maxVal;
    }
}
