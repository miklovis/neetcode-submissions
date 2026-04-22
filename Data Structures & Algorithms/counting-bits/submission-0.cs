public class Solution {
    public int[] CountBits(int n) {
        int[] ones = new int[n+1];
        for (int i = 0; i <= n; i++) {
            int j = i;
            while (j > 1) {
                if (j % 2 == 1) {
                    ones[i]++;
                }
                j = j >> 1;
            }
            if (j == 1) {
                ones[i]++;
            }
        }

        return ones;
    }
}
 