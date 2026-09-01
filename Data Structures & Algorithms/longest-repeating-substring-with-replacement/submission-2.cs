public class Solution {
    public int CharacterReplacement(string s, int k) {
            // Since the constraint says "only uppercase english characters", 
            // a fixed array of size 26 acts as our ultra-fast map.
            int[] counts = new int[26];
            
            int left = 0;
            int maxRepeatCount = 0;
            int maxLength = 0;
            
            for (int right = 0; right < s.Length; right++) {
                // Map the uppercase character to an index from 0 to 25
                int rightCharIndex = s[right] - 'A';
                counts[rightCharIndex]++;
                
                // Update the highest frequency found in the current valid window history
                maxRepeatCount = Math.Max(maxRepeatCount, counts[rightCharIndex]);
                
                // Current window size is (right - left + 1)
                // If the letters we need to replace > k, shrink the window from the left
                if ((right - left + 1) - maxRepeatCount > k) {
                    int leftCharIndex = s[left] - 'A';
                    counts[leftCharIndex]--;
                    left++; // Slide the left pointer up
                }
                
                // Track the maximum valid window size seen
                maxLength = Math.Max(maxLength, right - left + 1);
            }
            
            return maxLength;
    }
}