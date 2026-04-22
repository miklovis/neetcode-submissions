public class Solution {
    public int[][] Insert(int[][] intervals, int[] newInterval) {
        int[][] newIntervals = new int[intervals.Length+1][];
        for (int i = 0; i < newIntervals.Length; i++) {
            newIntervals[i] = new int[2];
        }

        if (intervals.Length == 0) {
            newIntervals[0] = newInterval;
        }


        bool inserted = false;

        for (int i = 0; i < intervals.Length; i++) {
            if (inserted) {
                break;
            }
            
            if (intervals[i][0] > newInterval[0]) {
                newIntervals[i] = newInterval;
                inserted = true;
                
                for(int j = i + 1; j < newIntervals.Length; j++) {
                    newIntervals[j] = intervals[j-1];
                }
                
                break;
            
            } else {
                newIntervals[i] = intervals[i];
            }
        }

        if (!inserted) {
            newIntervals[intervals.Length] = newInterval;
        }

        for(int i = 0; i < newIntervals.Length; i++) {
            Console.WriteLine(newIntervals[i][0] + " " + newIntervals[i][1]);
        }

        for(int i = 1; i < newIntervals.Length; i++) {
            if (newIntervals[i][0] <= newIntervals[i-1][1]) {
                if (newIntervals[i-1][1] < newIntervals[i][1]){
                    newIntervals[i-1][1] = newIntervals[i][1];
                }
                
                var list = newIntervals.ToList();
                list.RemoveAt(i);
                newIntervals = list.ToArray();

                for(int j = 0; j < newIntervals.Length; j++) {
                    Console.Write(newIntervals[j][0] + " " + newIntervals[j][1] + ", ");
                }
                Console.WriteLine(" ");

                i--;
            }
        }

        return newIntervals;
    }

}
