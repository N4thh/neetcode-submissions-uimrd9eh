public class Solution {
    public int CharacterReplacement(string s, int k) {
        int[] count = new int[26];
    int left = 0;
    int maxCount = 0;
    int result = 0;

    for (int right = 0; right < s.Length; right++)
    {
        int index = s[right] - 'A';
        count[index]++;

        maxCount = Math.Max(maxCount, count[index]);

        int windowSize = right - left + 1;

        if (windowSize - maxCount > k)
        {
            count[s[left] - 'A']--;
            left++;
        }

        result = Math.Max(result, right - left + 1);
    }

    return result;
    }
}
