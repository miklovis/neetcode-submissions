public class Solution {
    public int NumIslands(char[][] grid) {
        int islands = 0;
        char[][] checkedArr = new char[grid.Length][];
        for (int i = 0; i < grid.Length; i++) {
            checkedArr[i] = new char[grid[0].Length];
            for (int j = 0; j < grid[0].Length; j++)
                {
                    checkedArr[i][j] = '0';
                }
        }

        for(int i = 0; i < grid.Length; i++) {
            for (int j = 0; j < grid[0].Length; j++) {
                if (checkedArr[i][j] == '0') {
                    if (grid[i][j] == '1') {
                        exploreIsland(grid, checkedArr, i, j);
                        islands++;

                    }
                }
            }
        }
        return islands;
    }

    public void exploreIsland(char[][] grid, char[][] checkedArr, int i, int j) {
        checkedArr[i][j] = '1';
        // down
        if (i < grid.Length - 1) {
            if (grid[i+1][j] == '1') {
                if (checkedArr[i+1][j] == '0') {
                    exploreIsland(grid, checkedArr, i+1, j);   
                }
            } else {
                checkedArr[i+1][j] = '1';
            }
        }

        // right
        if (j < grid[0].Length - 1) {
            if (grid[i][j+1] == '1') {
                if (checkedArr[i][j+1] == '0') {
                    exploreIsland(grid, checkedArr, i, j+1);
                }
            } else {
                checkedArr[i][j+1] = '1';
            }
        }

        // up
        if (i > 0) {
            if (grid[i-1][j] == '1') {
                if (checkedArr[i-1][j] == '0') {
                    exploreIsland(grid, checkedArr, i-1, j);
                }
            } else {
                checkedArr[i-1][j] = '1';
            }
        }
        // left
        if (j > 0) {
            if (grid[i][j-1] == '1') {
                if (checkedArr[i][j-1] == '0') {
                    exploreIsland(grid, checkedArr, i, j-1);
                }
            } else {
                checkedArr[i][j-1] = '1';
            }
        }
    }
}