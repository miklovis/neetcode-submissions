public class KthLargest {

    List<int> nums;
    int kth;

    public KthLargest(int k, int[] nums) {
        this.kth = k;
        this.nums = nums.OfType<int>().ToList(); 
    }
    
    public int Add(int val) {
        nums.Add(val);
        
        nums.Sort();
        nums.Reverse();

        return nums[kth-1];
    }
}
