public class Solution {

    public string Encode(IList<string> strs) {
        string encoded = "";
        
        foreach (string str in strs) {
            encoded += str;
            encoded += ';';
        }

        return encoded;
    }

    public List<string> Decode(string s) {
        var decoded = new List<string>();

        while(s.IndexOf(';') != -1) {
            int delimiterIndex = s.IndexOf(';');

            decoded.Add(s.Substring(0, delimiterIndex));

            s = s.Substring(delimiterIndex + 1);
        }

        return decoded;
   }
}
