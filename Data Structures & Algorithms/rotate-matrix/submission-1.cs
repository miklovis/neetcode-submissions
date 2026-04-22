public class Solution {
    public void Rotate(int[][] matrix) {
        int left = 0;
        int right = matrix.Length - 1;

        while (left < right) {
            for(int i = 0; i < (right - left); i++)
            {    
                int top = left;
                int bottom = right;

                // take temp copy of top left
                int topLeft = matrix[top][left + i];

                // put bottom left into top left
                matrix[top][left + i] = matrix[bottom - i][left];

                // put bottom right into bottom left
                matrix[bottom - i][left] = matrix[bottom][right - i];

                // put top right into bottom right
                matrix[bottom][right - i] = matrix[top + i][right];

                // put temp copy into top right
                matrix[top + i][right] = topLeft;
            }

            left++;
            right--;
        }
    }
}
