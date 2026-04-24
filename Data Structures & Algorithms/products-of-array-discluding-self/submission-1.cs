public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int total = 1;
        int[] products = new int[nums.Length];

        int zeroCount = 0;
        foreach (int num in nums) {
            total *= num;
            if (num == 0) {
                zeroCount++;
            }
        }

        if (zeroCount > 1) {
            for(int i = 0; i < nums.Length; i++) {
                products[i] = 0;
            }

            return products;
        }

        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] == 0) {
                int newTotal = 1;
                foreach (int num in nums) {
                    if (num != 0) {
                        newTotal *= num;
                    }
                }

                products[i] = newTotal;
            }
            else {
                products[i] = total / nums[i];
            }
        }

        return products;
    }
}
