public class Solution {
    public int ClimbStairs(int n) {
        int previous = 0;
        int current = 1;
        int total = 0;

        for (int i = n; i > 0; i--) {
            total = previous + current;
            previous = current;
            current = total;
        }

        return total;
    }
}
