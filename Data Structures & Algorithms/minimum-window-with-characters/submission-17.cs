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
            //Console.WriteLine();
            //Console.WriteLine(s[right] + " " + copyOfOriginal.ContainsKey(s[right]));
            if(copyOfOriginal.ContainsKey(s[right])) {
                //Console.WriteLine(s.Substring(left, right - left + 1) + " " + copyOfOriginal[s[right]]);

                copyOfOriginal[s[right]]--;
                if(copyOfOriginal[s[right]] == 0) {
                    missing--;
                }
            
                // see if the characters align
                // if yes, take the minimum length's string, move the left pointer
                // if no, next loop

                //foreach(var dic in copyOfOriginal) {
                //    Console.WriteLine(dic.Value + "  " + dic.Key);
                //}
                //Console.WriteLine("missing " + missing);

                while(missing == 0){
                    if((right - left + 1) < bestLen || bestLen == 0) {
                        bestStart = left;
                        bestLen = right - left + 1;
                    }

                    //Console.WriteLine("WINNER " + s.Substring(bestStart, bestLen));

                    if(copyOfOriginal.ContainsKey(s[left])){
                        //Console.WriteLine("endgame " + s[left] + " " + copyOfOriginal[s[left]]);
                        copyOfOriginal[s[left]]++;

                        if(copyOfOriginal[s[left]] >= 1) {
                            missing++;
                        }
                    }

                    if(left < right) {
                        left++;
                    }
                }

                    //if(right >= left) {
                    //    copyOfOriginal[s[right]]++;
                    //    right--;
                    //}

            }
        }

        //Console.WriteLine(bestStart + " " + bestLen);
        if(bestStart == 0 && bestLen == 0) {
            return result;
        }
        else {
            result = s.Substring(bestStart, bestLen);
        }

        return result;
    }
}
