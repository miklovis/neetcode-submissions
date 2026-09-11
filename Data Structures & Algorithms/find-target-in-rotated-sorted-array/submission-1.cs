public class Solution {
    public int Search(int[] nums, int target) {
        int start = 0;

        for(int i = 1; i < nums.Length; i++) {
            if(nums[i-1] > nums[i]) {
                start = i;
            }
        }

        //Console.WriteLine(start);

        if (start == 0) {
            for(int i = 0; i < nums.Length; i++) {
                if (nums[i] == target) {
                    return i;
                }
            }
        }
        if (target >= nums[0]) {
            for(int i = 0; i < start; i++) {
                if (nums[i] == target) {
                    return i;
                }
            }
        } else {
            for (int i = start; i < nums.Length; i++) {
                if (nums[i] == target) {
                    return i;
                }
            }
        }

        return -1;
    }
}
