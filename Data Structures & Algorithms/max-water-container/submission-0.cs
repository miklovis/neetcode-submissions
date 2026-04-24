public class Solution {
    public int MaxArea(int[] heights) {
        int maxArea = 0;
        
        for (int i = 0; i < heights.Length - 1; i++) {
            for (int j = i + 1; j < heights.Length; j++) {
                var height = heights[i] > heights[j] ? heights[j] : heights[i];
                var width = j - i;

                var currentArea = height * width;
                
                if (maxArea < currentArea) { 
                    maxArea = currentArea;
                }
            }
        }

        return maxArea;
    }
}
