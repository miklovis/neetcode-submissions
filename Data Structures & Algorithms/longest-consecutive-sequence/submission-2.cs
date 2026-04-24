public class Solution {
    public int LongestConsecutive(int[] nums) {
        Array.Sort(nums);
        int maxStreak = 0;
        int currentStreak = nums.Length > 0 ? 1 : 0;
        int? previousNumber = null;
        
        foreach(int num in nums) {
            //Console.WriteLine("number " + num + ", previous number " + previousNumber);
            
            if(previousNumber == num) {
                continue;
            } 
            else if(previousNumber + 1 == num && previousNumber != null) {
                currentStreak++;
            } else {
                if (currentStreak > maxStreak) {
                    maxStreak = currentStreak;
                }
                currentStreak = 1;
            }

            previousNumber = num;
        }

        if (currentStreak > maxStreak) {
            maxStreak = currentStreak;
        }

        return maxStreak;
    }
}
