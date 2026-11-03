public class Solution {
    public int LongestCommonSubsequence(string text1, string text2) {
        int[,] dp = new int[text1.Length, text2.Length];

        // Đánh dấu tất cả trạng thái chưa được tính
        for (int i = 0; i < text1.Length; i++) {
            for (int j = 0; j < text2.Length; j++) {
                dp[i, j] = -1;
            }
        }

        return dfs(0, 0, text1, text2, dp);
    }

    private int dfs(int i, int j, string s1, string s2, int[,] dp) {
        if (i == s1.Length || j == s2.Length)
            return 0;

        // Đã tính rồi thì lấy kết quả từ memo
        if (dp[i, j] != -1)
            return dp[i, j];

        if (s1[i] == s2[j]) {
            return dp[i, j] = 1 + dfs(i + 1, j + 1, s1, s2, dp);
        }

        int path1 = dfs(i + 1, j, s1, s2, dp);
        int path2 = dfs(i, j + 1, s1, s2, dp);

        return dp[i, j] = Math.Max(path1, path2);
    }
}