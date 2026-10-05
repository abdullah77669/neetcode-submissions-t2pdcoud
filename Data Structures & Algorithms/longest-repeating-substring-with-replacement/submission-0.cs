public class Solution
{
    public int CharacterReplacement(string s, int k)
    {
        int[] count = new int[26];

        int left = 0;
        int maxFrequency = 0;
        int maxLength = 0;

        for (int right = 0; right < s.Length; right++)
        {
            count[s[right] - 'A']++;

            maxFrequency = Math.Max(
                maxFrequency,
                count[s[right] - 'A']
            );

            int windowLength = right - left + 1;
            int replacements = windowLength - maxFrequency;

            if (replacements > k)
            {
                count[s[left] - 'A']--;
                left++;
            }

            maxLength = Math.Max(maxLength, right - left + 1);
        }

        return maxLength;
    }
}