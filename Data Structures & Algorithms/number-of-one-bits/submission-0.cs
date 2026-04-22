public class Solution {
    public int HammingWeight(uint n) {
        int ones = 0;
        for (int i = 0; i < 32; i++) {
            if (n % 2 == 1) {
                ones++;
            }

            n = n >> 1;
        }
        return ones;
    }
}
