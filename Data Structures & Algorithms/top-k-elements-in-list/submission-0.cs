public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        int[] result = new int[k];
        Dictionary<int, int> dict = new Dictionary<int, int>();

        foreach (int num in nums) {
            if (dict.ContainsKey(num)) {
                dict[num]++;
            } else {
                dict[num] = 1;
            }
        }

        int index = 0;
        foreach (KeyValuePair<int, int> number in dict.OrderByDescending(key => key.Value)) {
            if (index == k) {
                break;
            }
            result[index] = number.Key;
            index++;
        }


        return result;
    }
}
