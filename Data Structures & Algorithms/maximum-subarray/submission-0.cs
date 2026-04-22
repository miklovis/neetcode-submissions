public class Solution {
    int max = -1000;
    
    public int MaxSubArray(int[] nums) {
        int total = 0;

        if (nums.Length > 1) {
            int[] numsCopy = new int[nums.Length - 1];

            Array.Copy(nums, 1, numsCopy, 0, nums.Length - 1);
            MaxSubArray(numsCopy);

            Array.Copy(nums, 0, numsCopy, 0, nums.Length - 1);
            MaxSubArray(numsCopy);
        }

        foreach (int element in nums)
        {
            total += element;
        }

        if (total > max) {
            max = total;
        }

        return max;
    }
}
