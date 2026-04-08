public class Solution {
    public int FindMin(int[] nums) {
        int left = 0, right = nums.Length - 1; 
        
        while (left < right) {
            int mid = left + (right - left) / 2;  // Tính chỉ số giữa

            // Nếu phần tử giữa lớn hơn phần tử cuối, nghĩa là phần tử nhỏ nhất nằm bên phải.
            if (nums[mid] > nums[right]) {
                left = mid + 1;
            } 
            // Nếu phần tử giữa nhỏ hơn hoặc bằng phần tử cuối, nghĩa là phần tử nhỏ nhất nằm bên trái.
            else {
                right = mid;
            }
        }
        
        // Khi vòng lặp kết thúc, left == right và đây là phần tử nhỏ nhất.
        return nums[left];
    }
}
