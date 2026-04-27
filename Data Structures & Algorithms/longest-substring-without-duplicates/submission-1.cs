public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int longestSubstring = 0;
        for(int i = 0; i < s.Length; i++) {
            for(int j = i; j < s.Length; j++) {
                HashSet<char> set = new HashSet<char>();
                bool unique = true;
                var substring = s.Substring(i, j - i + 1);
                //Console.WriteLine(substring + " " + substring.Length);

                foreach (char c in substring) {
                    if (set.Contains(c)) {
                        unique = false;
                        break;
                    } else {
                        set.Add(c);
                    }
                }

                if (unique && substring.Length > longestSubstring) {
                    longestSubstring = substring.Length;
                }
            }
        }

        return longestSubstring;
    }
}
