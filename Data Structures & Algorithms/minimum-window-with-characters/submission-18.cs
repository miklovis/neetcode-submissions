public class Solution {
    public string MinWindow(string s, string t) {
        if (t.Length > s.Length) {
            return "";
        }

        int left = 0;
        int missing = 0;

        var copyOfOriginal = new Dictionary<char, int>();
        string result = "";
        int bestStart = 0;
        int bestLen = 0;
        
        foreach (var c in t) {
            copyOfOriginal.TryGetValue(c, out var count);

            if(count > 0) {
                copyOfOriginal[c]++;
            } else {
                copyOfOriginal[c] = 1;
                missing++;
            }
        }
 
        for (int right = 0; right < s.Length; right++) {
            if(copyOfOriginal.ContainsKey(s[right])) {

                copyOfOriginal[s[right]]--;
                if(copyOfOriginal[s[right]] == 0) {
                    missing--;
                }
            
                while(missing == 0){
                    if((right - left + 1) < bestLen || bestLen == 0) {
                        bestStart = left;
                        bestLen = right - left + 1;
                    }

                    if(copyOfOriginal.ContainsKey(s[left])){
                        copyOfOriginal[s[left]]++;

                        if(copyOfOriginal[s[left]] >= 1) {
                            missing++;
                        }
                    }

                    if(left < right) {
                        left++;
                    }
                }
            }
        }

        if(bestStart == 0 && bestLen == 0) {
            return result;
        }
        else {
            result = s.Substring(bestStart, bestLen);
        }

        return result;
    }
}
