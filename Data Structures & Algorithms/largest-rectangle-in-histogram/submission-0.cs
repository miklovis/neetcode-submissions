public class Solution {
    public int LargestRectangleArea(int[] heights) {
        int maxArea = 0;

        for (int i = 0; i < heights.Length; i++) {
            for (int j = i; j < heights.Length; j++) {
                var height = heights[i];

                for (int k = i; k <= j; k++) {
                    if (heights[k] < height) {
                        height = heights[k];
                    }
                }

                var width = j - i + 1;
                //Console.WriteLine("width " + width + " height " + height + " i " + i + " j " + j);
                var currentArea = height * width;

                if (maxArea < currentArea) {
                    maxArea = currentArea;
                }
            }
        }

        return maxArea;
    }
}
