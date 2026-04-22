public class Solution {
    int total = 0;
    
    public int UniquePaths(int m, int n) {
    /*    if (m > 1) {
            UniquePaths(m-1, n);
        } else {
            total++;
            return 1;
        }
        if (n > 1) {
            UniquePaths(m, n-1);
        } else {
            total++;
            return 1;
        }
    }

    return total;

*/

        if (m == 1 || n == 1) {
            total++;
            return 1;
        }

        if (m > 1) {
            UniquePaths(m-1, n);
        }

        if (n > 1) {
            UniquePaths(m, n-1);
        }

        return total;
    }
}
